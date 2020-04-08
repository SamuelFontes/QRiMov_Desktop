CREATE PROCEDURE InsereUsuario --- Declarando o nome da procedure
--- variaveis que virá do sistema --
@idEnd int,
@idMail int,
@idUser int,
@idTel int,
@nome VARCHAR (60),
@status VARCHAR (30),
@cpf VARCHAR (20),
@dtNasc VARCHAR (20),
@user VARCHAR (20),
@senha VARCHAR (20),
@cep VARCHAR (20),
@logr VARCHAR (60),
@num VARCHAR (20),
@bairro VARCHAR (30),
@cidade varchar (30),
@uf VARCHAR (4),
@email VARCHAR (60),
@descEmail VARCHAR (60),
@telefone varchar (20),
@celular varchar (20)
AS
begin try
	begin tran
		--- insert com os dados da tabela usuario
		INSERT INTO USUARIO  VALUES (@nome,@status,@cpf,@dtNasc, getdate() ,@user,@senha);
		--- pega o ultimo ID cadastrado
		SELECT @idUser= SCOPE_IDENTITY();

		INSERT INTO ENDERECO (str_cep_end,str_logradouro_end,str_numero_end,str_bairro_end,str_comarca_end,str_uf_end) VALUES (@cep, @logr,@num,@bairro,@cidade,@uf);

		SELECT @idEnd= SCOPE_IDENTITY();

		INSERT INTO EMAIL VALUES (@email, @descEmail);

		SELECT @idMail= SCOPE_IDENTITY();

		INSERT INTO TELEFONE VALUES (@telefone, null);

		SELECT @idTel= SCOPE_IDENTITY();

		INSERT INTO TELEFONE VALUES (@celular, null);

		SELECT @idTel= SCOPE_IDENTITY();

		INSERT INTO link_end_usr  VALUES (@idEnd, @idUser);

		INSERT INTO link_tel_usr VALUES (@idTel,@idUser);
	commit tran
end try
begin catch
	SELECT ERROR_MESSAGE();
	if @@Trancount>0
		rollback tran
end catch