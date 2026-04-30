package com.deosermis.backend.controller;

import com.deosermis.backend.model.Produto;
import com.deosermis.backend.repository.ProdutoRepository;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.Optional;

@RestController
@RequestMapping("/produtos")
@CrossOrigin("*")
public class ProdutoController {

    @Autowired
    private ProdutoRepository repository;

    // LISTAR TODOS
    @GetMapping
    public List<Produto> listar() {
        return repository.findAll();
    }

    //  BUSCAR POR ID
    @GetMapping("/{id}")
    public Produto buscarPorId(@PathVariable Long id) {
        Optional<Produto> produto = repository.findById(id);
        return produto.orElse(null);
    }

    // INSERIR
    @PostMapping
    public Produto salvar(@RequestBody Produto p) {
        return repository.save(p);
    }

    //️ ATUALIZAR
    @PutMapping("/{id}")
    public Produto atualizar(@PathVariable Long id, @RequestBody Produto p) {
        Optional<Produto> existente = repository.findById(id);

        if (existente.isPresent()) {
            Produto produto = existente.get();
            produto.setNome(p.getNome());
            produto.setQuantidade(p.getQuantidade());
            produto.setValor(p.getValor());
            return repository.save(produto);
        } else {
            return null;
        }
    }

    // DELETAR
    @DeleteMapping("/{id}")
    public String deletar(@PathVariable Long id) {
        if (repository.existsById(id)) {
            repository.deleteById(id);
            return "Produto deletado com sucesso!";
        } else {
            return "Produto não encontrado!";
        }
    }
}