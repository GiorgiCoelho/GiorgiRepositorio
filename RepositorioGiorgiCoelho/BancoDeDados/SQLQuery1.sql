select L.Titulo, L.AnoPublicacao, A.Nome from Livro as L, Autor as A
where A.Id = L.Autor_Id -- Mostra a tabela livro com o nome dos autores no lugar do Id.