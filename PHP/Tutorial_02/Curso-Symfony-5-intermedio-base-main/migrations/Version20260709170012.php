<?php

declare(strict_types=1);

namespace DoctrineMigrations;

use Doctrine\DBAL\Schema\Schema;
use Doctrine\Migrations\AbstractMigration;

final class Version20260709170012 extends AbstractMigration
{
    public function getDescription(): string
    {
        return 'Añade el campo finalizada a la tabla tarea.';
    }

    public function up(Schema $schema): void
    {
        $this->addSql(
            'ALTER TABLE tarea ADD finalizada TINYINT(1) NOT NULL'
        );
    }

    public function down(Schema $schema): void
    {
        $this->addSql(
            'ALTER TABLE tarea DROP finalizada'
        );
    }
}
