/* Lógico_1 - Copia: */

CREATE TABLE Cadastro (
    CodigoCliente int PRIMARY KEY,
    Cpf string,
    Nome string string,
    Rua string,
    Numero int,
    Complemento string,
    Cep char,
    Situacao situacao,
    E_mail string
);

CREATE TABLE EFMigrationsHistory (
    Migrational int PRIMARY KEY
);

CREATE TABLE Relacionamento_1 (
    fk_Cadastro_CodigoCliente int,
    fk_EFMigrationsHistory_Migrational int
);
 
ALTER TABLE Relacionamento_1 ADD CONSTRAINT FK_Relacionamento_1_1
    FOREIGN KEY (fk_Cadastro_CodigoCliente)
    REFERENCES Cadastro (CodigoCliente)
    ON DELETE SET NULL;
 
ALTER TABLE Relacionamento_1 ADD CONSTRAINT FK_Relacionamento_1_2
    FOREIGN KEY (fk_EFMigrationsHistory_Migrational)
    REFERENCES EFMigrationsHistory (Migrational)
    ON DELETE SET NULL;