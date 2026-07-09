$('.finalizar').on('click', function (e) {
    e.preventDefault();

    const $this = $(this);
    const url = $this.data('url');
    const $descripcion = $this.closest('tr').find('.descripcion');
    const textoContrario = $this.data('textoContrario');
    const textoActual = $this.text();

    $this.addClass('disabled');

    $.post(url, {})
        .done(function (respuesta) {
            if (respuesta.finalizada) {
                $descripcion.text(`<s>${$descripcion.text()}</s>`);
            } else {
                $descripcion.text($descripcion.text());
            }

            $this.text(textoContrario);
            $this.data('textoContrario', textoActual);
            $this.removeClass('disabled');
        })
        .fail(function () {
            $this.removeClass('disabled');
        });
});