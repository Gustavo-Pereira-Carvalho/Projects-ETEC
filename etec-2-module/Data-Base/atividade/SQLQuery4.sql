create procedure uspAddEndereco
    @acao int, 
    @idcodigo int = null,
    @codcontato int = null,
    @endereco varchar(80) = null,
    @numero int = null,
    @complemento varchar(30) = null,
    @bairro varchar(30) = null,
    @cidade varchar(30) = null,
    @estado char(2) = null,
    @cep varchar(9) = null
as
begin
    -- Excluir Endere�o
    if (@acao = 0)
    begin
        delete from endereco
        where codcontato = @codcontato
        select @codcontato as Retorno
        return
    end

    -- Inserir Endere�o
    else if (@acao = 1)
    begin
        declare @existe as bit
        set @existe = (select count(*) from endereco where cep = @cep and codcontato = @codcontato)

        if @existe = 0
        begin
            insert into endereco (codcontato, endereco, numero, complemento, bairro, cidade, estado, cep)
            values (@codcontato, @endereco, @numero, @complemento, @bairro, @cidade, @estado, @cep)
            select @@identity as Retorno
        end
        else
        begin
            raiserror('O endere�o com este CEP j� existe para este contato', 16, 1)
            return
        end
    end

    -- Alterar Endere�o
    else if (@acao = 2)
    begin
        update endereco
        set endereco = @endereco,
            numero = @numero,
            complemento = @complemento,
            bairro = @bairro,
            cidade = @cidade,
            estado = @estado,
            cep = @cep
        where idcodigo = @idcodigo
        select @idcodigo as Retorno
    end
    else
    begin
        raiserror('A��o n�o implementada', 16, 1)
        return
    end
end
select *from endereco
select * from contato
select * from telefone
-- Inserir um endere�o
exec uspAddEndereco 1, null, 2, 'Rua A', 123, 'Apto 101', 'Centro', 'S�o Paulo', 'S', '01000-000';

-- Atualizar um endere�o
exec uspAddEndereco 2, 1, 1, 'Rua B', 456, 'Casa', 'Jardim', 'S�o Paulo', 'SP', '02000-000';

-- Excluir endere�o
exec uspAddEndereco 0, null, 1;
