<?php

declare(strict_types=1);

namespace App\Validator;

use Symfony\Component\Validator\Constraint;

/**
 * @Annotation
 */
final class TareaUnica extends Constraint
{
    public string $message = 'Ya existe una tarea con la descripción "{{ value }}".';

    /**
     * Indica que la validación se realiza a nivel de entidad
     * y no sobre una propiedad concreta.
     *
     * Debe aplicarse sobre la entidad:
     *
     * @AppAssert\TareaUnica
     */
    public function getTargets(): string
    {
        return self::CLASS_CONSTRAINT;
    }
}
