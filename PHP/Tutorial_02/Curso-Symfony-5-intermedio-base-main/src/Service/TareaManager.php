<?php

declare(strict_types=1);

namespace App\Service;

use App\Entity\Tarea;
use Doctrine\ORM\EntityManagerInterface;
use Symfony\Component\Validator\ConstraintViolationListInterface;
use Symfony\Component\Validator\Validator\ValidatorInterface;

class TareaManager
{
    /**
     * @var EntityManagerInterface
     */
    private $entityManager;

    /**
     * @var ValidatorInterface
     */
    private $validator;

    public function __construct(
        EntityManagerInterface $entityManager,
        ValidatorInterface $validator
    ) {
        $this->entityManager = $entityManager;
        $this->validator = $validator;
    }

    public function crear(Tarea $tarea): void
    {
        $this->entityManager->persist($tarea);
        $this->entityManager->flush();
    }

    public function editar(Tarea $tarea): void
    {
        $this->entityManager->flush();
    }

    public function eliminar(Tarea $tarea): void
    {
        $this->entityManager->remove($tarea);
        $this->entityManager->flush();
    }

    public function validar(Tarea $tarea): ConstraintViolationListInterface
    {
        return $this->validator->validate($tarea);
    }
}
