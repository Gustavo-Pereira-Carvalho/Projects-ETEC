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
    -- Excluir Endereço
    if (@acao = 0)
    begin
        delete from endereco
        where codcontato = @codcontato
        select @codcontato as Retorno
        return
    end

    -- Inserir Endereço
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
            raiserror('O endereço com este CEP já existe para este contato', 16, 1)
            return
        end
    end

    -- Alterar Endereço
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
        raiserror('Ação não implementada', 16, 1)
        return
    end
end
select *from endereco
select * from contato
select * from telefone
-- Inserir um endereço
exec uspAddEndereco 1, null, 2, 'Rua A', 123, 'Apto 101', 'Centro', 'São Paulo', 'S', '01000-000';

-- Atualizar um endereço
exec uspAddEndereco 2, 1, 1, 'Rua B', 456, 'Casa', 'Jardim', 'São Paulo', 'SP', '02000-000';

-- Excluir endereço
exec uspAddEndereco 0, null, 1;
