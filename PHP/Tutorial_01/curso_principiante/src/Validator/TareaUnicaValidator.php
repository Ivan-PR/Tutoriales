<?php

namespace App\Validator;

use App\Entity\Tarea;
use App\Repository\TareaRepository;
use Symfony\Component\Validator\Constraint;
use Symfony\Component\Validator\ConstraintValidator;

class TareaUnicaValidator extends ConstraintValidator
{
    private TareaRepository $tareaRepository;

    public function __construct(TareaRepository $tareaRepository)
    {
        $this->tareaRepository = $tareaRepository;
    }

    public function validate($tarea, Constraint $constraint): void
    {
        if (!$tarea instanceof Tarea) {
            return;
        }

        $descripcion = $tarea->getDescripcion();

        if (null === $descripcion || '' === $descripcion) {
            return;
        }

        $tareaExistente = $this->tareaRepository->findOneByDescripcion($descripcion);

        if (null !== $tareaExistente && $tarea->getId() !== $tareaExistente->getId()) {
            $this->context->buildViolation($constraint->message)
                ->setParameter('{{ value }}', $descripcion)
                ->addViolation();
        }
    }
}
