<?php

declare(strict_types=1);

namespace App\DataFixtures;

use App\Entity\Tarea;
use Doctrine\Bundle\FixturesBundle\Fixture;
use Doctrine\Persistence\ObjectManager;

final class TareaFixtures extends Fixture
{
    public function load(ObjectManager $manager): void
    {
        for ($i = 0; $i < 20; ++$i) {
            $tarea = new Tarea();

            $tarea->setDescripcion("Tarea de prueba - {$i}");
            $tarea->setFinalizada(false);

            $manager->persist($tarea);
        }

        $manager->flush();
    }
}
