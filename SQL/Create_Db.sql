CREATE DATABASE DuLieu ON (
	NAME = 'DuLieu_data',
	FILENAME = 'E:\ktra_LTTQ\Du_data.mdf',
	SIZE = 10MB,
	MAXSIZE = 100MB,
	FILEGROWTH = 5MB
) LOG ON (
	NAME = 'DuLieu_log',
	FILENAME = 'E:\ktra_LTTQ\DuLieu_log.ldf',
	SIZE = 5MB,
	MAXSIZE = 50MB,
	FILEGROWTH = 3MB
);