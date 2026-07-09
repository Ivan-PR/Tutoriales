<?php

declare(strict_types=1);

namespace App\Entity;

use App\Repository\TareaRepository;
use App\Validator as AppAssert;
use Doctrine\ORM\Mapping as ORM;
use Symfony\Component\Validator\Constraints as Assert;

/**
 * @AppAssert\TareaUnica
 * @ORM\Entity(repositoryClass=TareaRepository::class)
 */
class Tarea
{
    /**
     * @ORM\Id
     * @ORM\GeneratedValue
     * @ORM\Column(type="integer")
     */
    private ?int $id = null;

    /**
     * @Assert\NotBlank(message="El campo descripción no puede estar vacío")
     * @ORM\Column(type="string", length=255)
     */
    private ?string $descripcion = null;

    /**
     * @ORM\Column(type="boolean")
     */
    private bool $finalizada = false;

    public function getId(): ?int
    {
        return $this->id;
    }

    public function getDescripcion(): ?string
    {
        return $this->descripcion;
    }

    public function setDescripcion(?string $descripcion): self
    {
        $this->descripcion = $descripcion;

        return $this;
    }

    public function getFinalizada(): bool
    {
        return $this->finalizada;
    }

    public function setFinalizada(bool $finalizada): self
    {
        $this->finalizada = $finalizada;

        return $this;
    }
}
