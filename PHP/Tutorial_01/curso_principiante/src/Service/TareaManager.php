<?php

namespace App\Service;

use App\Entity\Tarea;
use App\Repository\TareaRepository;
use Doctrine\ORM\EntityManagerInterface;
use Symfony\Component\Validator\Validator\ValidatorInterface;

class TareaManager
{
    private $em;
    private $tareaRepository;
    private $validator;

    public function __construct(TareaRepository $tareaRepository, EntityManagerInterface $em, ValidatorInterface $validator)
    {
        $this->em = $em;
        $this->tareaRepository = $tareaRepository;
        $this->validator = $validator;
    }

    public function crear(Tarea $tarea)
    {
        $this->em->persist($tarea);
        $this->em->flush();
    }

    public function editar(Tarea $tarea): void
    {
        $this->em->flush();
    }

    public function eliminar(Tarea $tarea): void
    {
        $this->em->remove($tarea);
        $this->em->flush();
    }

    public function validar(Tarea $tarea)
    {
        $errores = $this->validator->validate($tarea);
        return $errores;
    }
}
