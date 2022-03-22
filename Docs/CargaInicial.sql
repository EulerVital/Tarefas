select * from tb_categoria

insert into tb_categoria (nome, descricao, data_criacao, excluido) values ('Categoria 1', 'Teste Categoria 1 descrição', GETDATE(), 0)
insert into tb_categoria (nome, descricao, data_criacao, excluido) values ('Categoria 2', 'Teste Categoria 2 descrição', GETDATE(), 0)
insert into tb_categoria (nome, descricao, data_criacao, excluido) values ('Categoria 3', 'Teste Categoria 3 descrição', GETDATE(), 0)
insert into tb_categoria (nome, descricao, data_criacao, excluido) values ('Categoria 4', 'Teste Categoria 4 descrição', GETDATE(), 0)
go

select * from tb_usuario

insert into tb_usuario (nome, email, senha, data_criacao, excluido) values ('Euler', 'eulervitalps@gmail.com', '1234', GETDATE(), 0)
insert into tb_usuario (nome, email, senha, data_criacao, excluido) values ('Jean', 'jeancarlos@gmail.com', '1234', GETDATE(), 0)
go

select * from tb_tarefa;

insert into tb_tarefa (nome, categoria_id, usuario_id, descricao, data_criacao, excluido) values ('Tarefa 1', 1, 1, 'Teste tarefa 1 descrição', GETDATE(), 0)
insert into tb_tarefa (nome, categoria_id, usuario_id, descricao, data_criacao, excluido) values ('Tarefa 1', 1, 2, 'Teste tarefa 1 descrição', GETDATE(), 0)
insert into tb_tarefa (nome, categoria_id, usuario_id, descricao, data_criacao, excluido) values ('Tarefa 2', 2, 1, 'Teste tarefa 2 descrição', GETDATE(), 0)
insert into tb_tarefa (nome, categoria_id, usuario_id, descricao, data_criacao, excluido) values ('Tarefa 3', 3, 1, 'Teste tarefa 3 descrição', GETDATE(), 0)
insert into tb_tarefa (nome, categoria_id, usuario_id, descricao, data_criacao, excluido) values ('Tarefa 4', 1, 1, 'Teste tarefa 4 descrição', GETDATE(), 0)
insert into tb_tarefa (nome, categoria_id, usuario_id, descricao, data_criacao, excluido) values ('Tarefa 2', 1, 2, 'Teste tarefa 2 descrição', GETDATE(), 0)
insert into tb_tarefa (nome, categoria_id, usuario_id, descricao, data_criacao, excluido) values ('Tarefa 3', 4, 2, 'Teste tarefa 3 descrição', GETDATE(), 0)
insert into tb_tarefa (nome, categoria_id, usuario_id, descricao, data_criacao, excluido) values ('Tarefa 5', 3, 1, 'Teste tarefa 5 descrição', GETDATE(), 0)