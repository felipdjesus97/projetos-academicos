package com.deosermis.backend.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import com.deosermis.backend.model.Produto;

public interface ProdutoRepository extends JpaRepository<Produto, Long> {
}