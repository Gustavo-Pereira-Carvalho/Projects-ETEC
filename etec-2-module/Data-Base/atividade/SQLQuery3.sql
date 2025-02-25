alter procedure uspAddTelefone
    @acao int,
    @idcodigo int = null,
    @codcontato int = null,
    @tipoTelefone varchar(15) = null,
    @telefone varchar(50) = null,
    @ramal varchar(4) = null
as
begin
    -- Excluir Telefone
    if (@acao = 0)
    begin
        delete from telefone
        where codcontato = @codcontato
        select @codcontato as Retorno
        return
    end

    -- Inserir Telefone
    else if (@acao = 1)
    begin
        declare @existe as bit
        set @existe = (select count(*) from telefone where telefone = @telefone and codcontato = @codcontato)

        if @existe = 0
        begin
            insert into telefone (codcontato, tipoTelefone, telefone, ramal)
            values (@codcontato, @tipoTelefone, @telefone, @ramal)
            select @@identity as Retorno
        end
        else
        begin
            raiserror('O telefone já existe para este contato', 16, 1)
            return
        end
    end

    -- Alterar Telefone
    else if (@acao = 2)
    begin
        update telefone
        set tipoTelefone = @tipoTelefone,
            telefone = @telefone,
            ramal = @ramal
        where idcodigo = @idcodigo
        select @idcodigo as Retorno
    end
    else
    begin
        raiserror('Ação não implementada', 16, 1)
        return
    end
end
select * from telefone
exec uspAddTelefone 1, null, 2, 'Celular', '99999-9999', null;

exec uspAddTelefone 2, 1003, 2, 'telefone', '99999-9999', 0320