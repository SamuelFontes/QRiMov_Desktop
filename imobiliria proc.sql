CREATE PROCEDURE InsereImobiliaria --- Declarando o nome da procedure
--- variaveis que virá do sistema --
@idEnd int,
@idMail int,
@idImob int,
@razao VARCHAR (60),
@fantasia VARCHAR (30),
@cnpj VARCHAR (20),
@ie VARCHAR (20),
@im VARCHAR (20),
@creci VARCHAR (20),
@cep VARCHAR (20),
@logr VARCHAR (60),
@num VARCHAR (20),
@bairro VARCHAR (30),
@cidade varchar (30),
@uf VARCHAR (4),
@email VARCHAR (60),
@descEmail VARCHAR (60)
AS
begin try
	begin tran
		--- insert com os dados da tabela usuario
		INSERT INTO ORGANIZACAO  VALUES (null,@cnpj,@razao,@fantasia,@ie, getdate() ,'Imobiliária',@creci,@im);
		--- pega o ultimo ID cadastrado
		SELECT @idImob= SCOPE_IDENTITY();

		INSERT INTO ENDERECO (str_cep_end,str_logradouro_end,str_numero_end,str_bairro_end,str_comarca_end,str_uf_end) VALUES (@cep, @logr,@num,@bairro,@cidade,@uf);

		SELECT @idEnd= SCOPE_IDENTITY();

		INSERT INTO EMAIL VALUES (@email, @descEmail);

		SELECT @idMail= SCOPE_IDENTITY();

		INSERT INTO LINK_END_ORG  VALUES (@idEnd, @idImob);
	commit tran
end try
begin catch
	SELECT ERROR_MESSAGE();
	if @@Trancount>0
		rollback tran
end catch