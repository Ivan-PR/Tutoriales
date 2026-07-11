<?php

declare(strict_types=1);

namespace App\Validator;

use App\Entity\Tarea;
use App\Repository\TareaRepository;
use Symfony\Component\Validator\Constraint;
use Symfony\Component\Validator\ConstraintValidator;

final class TareaUnicaValidator extends ConstraintValidator
{
    /**
     * @var TareaRepository
     */
    private $tareaRepository;

    public function __construct(TareaRepository $tareaRepository)
    {
        $this->tareaRepository = $tareaRepository;
    }

    /**
     * @param Tarea|null $value
     */
    public function validate($value, Constraint $constraint): void
    {
        if (!$value instanceof Tarea) {
            return;
        }

        $descripcion = $value->getDescripcion();

        if ($descripcion === null || $descripcion === '') {
            return;
        }

        $tareaExistente = $this->tareaRepository
            ->buscarTareaPorDescripcion($descripcion);

        if (
            $tareaExistente !== null
            && $value->getId() !== $tareaExistente->getId()
        ) {
            $this->context
                ->buildViolation($constraint->message)
                ->setParameter('{{ value }}', $descripcion)
                ->addViolation();
        }
    }
}
