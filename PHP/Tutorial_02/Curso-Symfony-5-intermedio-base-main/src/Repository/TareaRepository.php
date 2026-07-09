<?php

declare(strict_types=1);

namespace App\Repository;

use App\Entity\Tarea;
use Doctrine\Bundle\DoctrineBundle\Repository\ServiceEntityRepository;
use Doctrine\ORM\Query;
use Doctrine\ORM\Tools\Pagination\Paginator;
use Doctrine\Persistence\ManagerRegistry;

/**
 * @extends ServiceEntityRepository<Tarea>
 *
 * @method Tarea|null find($id, $lockMode = null, $lockVersion = null)
 * @method Tarea|null findOneBy(array $criteria, array $orderBy = null)
 * @method Tarea[]    findAll()
 * @method Tarea[]    findBy(array $criteria, array $orderBy = null, $limit = null, $offset = null)
 */
final class TareaRepository extends ServiceEntityRepository
{
    public function __construct(ManagerRegistry $registry)
    {
        parent::__construct($registry, Tarea::class);
    }

    public function paginacion(
        Query $query,
        int $pagina,
        int $elementosPorPagina
    ): Paginator {
        $paginador = new Paginator($query);

        $paginador->getQuery()
            ->setFirstResult($elementosPorPagina * ($pagina - 1))
            ->setMaxResults($elementosPorPagina);

        return $paginador;
    }

    public function buscarTodas(
        int $pagina = 1,
        int $elementosPorPagina = 5
    ): Paginator {
        $query = $this->createQueryBuilder('t')
            ->getQuery();

        return $this->paginacion($query, $pagina, $elementosPorPagina);
    }

    public function buscarTareaPorDescripcion(string $descripcion): ?Tarea
    {
        return $this->createQueryBuilder('t')
            ->andWhere('t.descripcion = :descripcion')
            ->setParameter('descripcion', $descripcion)
            ->getQuery()
            ->getOneOrNullResult();
    }
}
