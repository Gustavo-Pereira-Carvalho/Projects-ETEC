create procedure uspAddContato
@Acao int, -- 0=excluir 1=inserir 2=alterar
@codigo int = null,
@nome varchar(50) = null,
@email varchar(100)=null,
@ativo bit = null
	as
		begin
			if(@Acao = 0) -- excluir
				begin
			delete from contato

			where codigo = @codigo
			select @codigo as Retorno
			end

		else if (@Acao = 1)--inserir
		begin
		 declare @existe as bit
		 set @existe = (select count (*) from contato where email = @email)
		 if @existe = 0 
		  begin
			insert into contato (nome, email, ativo)
			values (@nome, @email, @ativo)
			select @@identity as Retorno
			end
			raiserror('O Email ja existe', 14, 1);
		end
		
		else if(@Acao = 2)--alterar
		begin
			update contato
			set nome = @nome, email = @email, ativo = @ativo
			where codigo = @codigo
			select @codigo as Retorno
		end
		begin
		raiserror('ação não implementada', 14, 1);
		end
		end
		/*
		select * from contato
		--adicionar
		exec uspAddContato 1, null, 'Gustavo Pereira', 'gustavo.carvalho198@etec.sp.gov.br', true
		exec uspAddContato 1, null, 'luiz', 'luizinho@gmail.com',true
		exec uspAddContato 1, null, 'amanda', 'amanda@gmail.com', true
		exec uspAddContato 1, null, 'luiza', 'luiza12231@gmail.com', false
		exec uspAddContato 1, null, 'pedro', 'pedro@gmail.com', true

		--excluir
		exec uspAddContato 0, 1, null
		--alterar
		exec uspAddContato 6, 4, 'amanda', 'amanda@gmail.com', false
		exec uspAddContato 2, 2, 'gustavo', 'gustavo.carvalho198@etec.sp.gov.br', false 
		*/

