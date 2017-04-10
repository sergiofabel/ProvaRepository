CREATE TABLE [dbo].[CEP] (
    [Cod_cep]  INT             NOT NULL,
    [Desc_cep] VARCHAR (60)    NOT NULL,
    [Lat_cep]  NUMERIC (10, 3) NOT NULL,
    [Long_cep] NUMERIC (10, 3) NOT NULL,
    PRIMARY KEY CLUSTERED ([Cod_cep] ASC)
);

