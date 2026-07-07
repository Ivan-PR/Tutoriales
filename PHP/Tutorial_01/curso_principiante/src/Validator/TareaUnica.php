<?php

namespace App\Validator;

use Symfony\Component\Validator\Constraint;

#[\Attribute(\Attribute::TARGET_CLASS)]
class TareaUnica extends Constraint
{
    public string $message = 'Ya existe una tarea con la descripción "{{ value }}".';

    public function getTargets(): string
    {
        return self::CLASS_CONSTRAINT;
    }
}
