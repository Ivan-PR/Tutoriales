<?php

namespace App\Controller;

use App\Entity\Tarea;
use App\Repository\TareaRepository;
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

    #[Route('/tarea/crear', name: 'app_crear_tarea')]
    public function crear(Request $request): Response
    {
        $tarea = new Tarea();
        $descripcion = $request->request->get('descripcion', null);
        if (null !== $descripcion) {
            if (!empty($descripcion)) {
                $em = $this->getDoctrine()->getManager();
                $tarea->setDescripcion($descripcion);
                $em->persist($tarea);
                $em->flush();
                $this->addFlash('success', 'Tarea creada correctamente!');
                return $this->redirectToRoute('app_listado_tarea');
            } else {
                $this->addFlash('warning', 'El campo descripción es obligatorio');
            }
        }
        return $this->render('tarea/crear.html.twig', [
            'tarea' => $tarea,
        ]);
    }

    #[Route('/tarea/editar/{id}', name: 'app_editar_tarea')]
    public function editar(int $id, TareaRepository $tareaRepository, Request $request): Response
    {
        $tarea = $tareaRepository->findOneById($id);
        if (null === $tarea) {
            throw $this->createNotFoundException();
        }
        $descripcion = $request->request->get('descripcion', null);
        if (null !== $descripcion) {
            if (!empty($descripcion)) {
                $em = $this->getDoctrine()->getManager();
                $tarea->setDescripcion($descripcion);
                $em->flush();
                $this->addFlash('success', 'Tarea editada correctamente!');
                return $this->redirectToRoute('app_listado_tarea');
            } else {
                $this->addFlash('warning', 'El campo descripción es obligatorio');
            }
        }
        return $this->render('tarea/editar.html.twig', [
            'tarea' => $tarea,
        ]);
    }

    #[Route('/tarea/eliminar/{id}', name: 'app_eliminar_tarea', requirements: ['id' => '\d+'])]
    public function eliminar(int $id): Response
    {
        return $this->render('tarea/listado.html.twig', [
            'controller_name' => 'TareaController',
        ]);
    }

    #[Route('/tarea/editar-params/{id}', name: 'app_editar_tarea_con_params_convert', requirements: ['id' => '\d+'])]
    public function editarConParamsConvert(Tarea $tarea, TareaRepository $tareaRepository, Request $request): Response
    {
        $descripcion = $request->request->get('descripcion', null);
        if (null !== $descripcion) {
            if (!empty($descripcion)) {
                $em = $this->getDoctrine()->getManager();
                $tarea->setDescripcion($descripcion);
                $em->flush();
                $this->addFlash('success', 'Tarea editada correctamente!');
                return $this->redirectToRoute('app_listado_tarea');
            } else {
                $this->addFlash('warning', 'El campo descripción es obligatorio');
            }
        }
        return $this->render('tarea/editar.html.twig', [
            'tarea' => $tarea,
        ]);
    }
}
