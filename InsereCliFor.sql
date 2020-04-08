CREATE PROCEDURE InsereCliFor --- Declarando o nome da procedure
--- variaveis que virá do sistema --
@idEnd int,
@idMail int,
@idOrg int,
@idTel int,
@razao VARCHAR (60),
@fantasia VARCHAR (30),
@identificacao VARCHAR (20),
@ie VARCHAR (20),
@im VARCHAR (20),
@tipo varchar (20),
@nome VARCHAR (60),
@cep VARCHAR (20),
@logr VARCHAR (60),
@num VARCHAR (20),
@bairro VARCHAR (30),
@cidade varchar (30),
@uf VARCHAR (4),
@email VARCHAR (60),
@descEmail VARCHAR (60),
@fixo varchar(20),
@celular varchar(20)
AS
begin try
	begin tran
		if(@tipo='cliente/fornecedor')
			begin
				INSERT INTO ORGANIZACAO  VALUES (@nome,@identificacao,@razao,@fantasia,@ie, getdate() ,'Cliente', null,@im);
				INSERT INTO ORGANIZACAO  VALUES (@nome,@identificacao,@razao,@fantasia,@ie, getdate() ,'Fornecedor', null,@im);
			end
		else
			begin
				--- insert com os dados da tabela organização
				INSERT INTO ORGANIZACAO  VALUES (@nome,@identificacao,@razao,@fantasia,@ie, getdate() ,@tipo, null,@im);
				--- pega o ultimo ID cadastrado
				SELECT @idOrg= SCOPE_IDENTITY();

				INSERT INTO ENDERECO (str_cep_end,str_logradouro_end,str_numero_end,str_bairro_end,str_comarca_end,str_uf_end) VALUES (@cep, @logr,@num,@bairro,@cidade,@uf);

				SELECT @idEnd= SCOPE_IDENTITY();

				INSERT INTO EMAIL VALUES (@email, @descEmail);

				SELECT @idMail= SCOPE_IDENTITY();

				INSERT INTO TELEFONE VALUES (@fixo, null);

				SELECT @idTel= SCOPE_IDENTITY();

				INSERT INTO link_tel_org VALUES (@idTel,@idOrg);

				INSERT INTO TELEFONE VALUES (@celular, null);

				SELECT @idTel= SCOPE_IDENTITY();

				INSERT INTO link_tel_org VALUES (@idTel,@idOrg);

				INSERT INTO LINK_END_ORG  VALUES (@idEnd, @idOrg);

				INSERT INTO LINK_MAIL_ORG VALUES (@idMail, @idOrg);
			end
	commit tran
end try
begin catch
	SELECT ERROR_MESSAGE();
	if @@Trancount>0
		rollback tran
end catch