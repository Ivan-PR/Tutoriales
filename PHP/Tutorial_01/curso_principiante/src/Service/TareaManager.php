<?php

namespace App\Service;

use App\Entity\Tarea;
use Doctrine\ORM\EntityManagerInterface;
use Symfony\Component\Validator\ConstraintViolationListInterface;
use Symfony\Component\Validator\Validator\ValidatorInterface;

class TareaManager
{
    private EntityManagerInterface $em;
    private ValidatorInterface $validator;

    public function __construct(
        EntityManagerInterface $em,
        ValidatorInterface $validator
    ) {
        $this->em = $em;
        $this->validator = $validator;
    }

    public function crear(Tarea $tarea): void
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

    public function validar(Tarea $tarea): ConstraintViolationListInterface
    {
        return $this->validator->validate($tarea);
    }
}
