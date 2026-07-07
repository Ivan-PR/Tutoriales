<?php

namespace App\Controller;

use App\Entity\Tarea;
use App\Repository\TareaRepository;
use App\Service\TareaManager;
use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\HttpFoundation\Request;
use Symfony\Component\HttpFoundation\Response;
use Symfony\Component\Routing\Annotation\Route;

class TareaController extends AbstractController
{
    #[Route('/', name: 'app_listado_tarea')]
    public function listado(TareaRepository $tareaRepository): Response
    {
        $tareas = $tareaRepository->findAll();
        return $this->render('tarea/listado.html.twig', [
            'tareas' => $tareas,
        ]);
    }

    #[Route('/tarea/crear-servicio', name: 'app_crear_tarea_servicio')]
    public function crear(TareaManager $tareaManager, Request $request): Response
    {
        $tarea = new Tarea();
        $descripcion = $request->request->get('descripcion', null);
        if (null !== $descripcion) {
            $tarea->setDescripcion($descripcion);
            $errores = $tareaManager->validar($tarea);

            if (0 === count($errores)) {
                $tareaManager->crear($tarea);
                $this->addFlash('success', 'Tarea creada correctamente!');
                return $this->redirectToRoute('app_listado_tarea');
            } else {
                foreach ($errores as $error) {
                    $this->addFlash('warning', $error->getMessage());
                }
            }
        }
        return $this->render('tarea/crear.html.twig', [
            'tarea' => $tarea,
        ]);
    }

    #[Route('/tarea/editar-servicio/{id}', name: 'app_editar_tarea_servicio', requirements: ['id' => '\d+'])]
    public function editar(Tarea $tarea, TareaManager $tareaManager, Request $request): Response
    {
        $descripcion = $request->request->get('descripcion', null);
        if (null !== $descripcion) {
            $tarea->setDescripcion($descripcion);
            $errores = $tareaManager->validar($tarea);
            if (0 === count($errores)) {
                $tareaManager->editar($tarea);
                $this->addFlash('success', 'Tarea editada correctamente!');
                return $this->redirectToRoute('app_listado_tarea');
            }
            foreach ($errores as $error) {
                $this->addFlash('warning', $error->getMessage());
            }
        }
        return $this->render('tarea/editar.html.twig', [
            'tarea' => $tarea,
        ]);
    }

    #[Route('/tarea/eliminar-servicio/{id}', name: 'app_eliminar_tarea_servicio', requirements: ['id' => '\d+'])]
    public function eliminar(Tarea $tarea, TareaManager $tareaManager): Response
    {
        $tareaManager->eliminar($tarea);

        $this->addFlash('success', 'Tarea eliminada correctamente!');

        return $this->redirectToRoute('app_listado_tarea');
    }

    #[Route('/tarea/editar-params-servicio/{id}', name: 'app_editar_tarea_con_params_convert_servicio', requirements: ['id' => '\d+'])]
    public function editarConParamsConvert(
        Tarea $tarea,
        TareaManager $tareaManager,
        Request $request
    ): Response {
        $descripcion = $request->request->get('descripcion', null);

        if (null !== $descripcion) {
            $tarea->setDescripcion($descripcion);
            $errores = $tareaManager->validar($tarea);
            if (0 === count($errores)) {
                $tareaManager->editar($tarea);
                $this->addFlash('success', 'Tarea editada correctamente!');
                return $this->redirectToRoute('app_listado_tarea');
            }
            foreach ($errores as $error) {
                $this->addFlash('warning', $error->getMessage());
            }
        }
        return $this->render('tarea/editar.html.twig', [
            'tarea' => $tarea,
        ]);
    }
}
