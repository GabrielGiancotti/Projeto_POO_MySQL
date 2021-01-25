-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 25-Jan-2021 às 18:43
-- Versão do servidor: 10.4.10-MariaDB
-- versão do PHP: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `trabalho_poo`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `agendamento`
--

DROP TABLE IF EXISTS `agendamento`;
CREATE TABLE IF NOT EXISTS `agendamento` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `data` varchar(50) NOT NULL,
  `hora` varchar(5) NOT NULL,
  `idpaciente` int(15) NOT NULL,
  `idmedico` int(15) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_idpacienteagendamento` (`idpaciente`),
  KEY `fk_idmedicoagendamento` (`idmedico`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `agendamento`
--

INSERT INTO `agendamento` (`id`, `data`, `hora`, `idpaciente`, `idmedico`) VALUES
(1, '21/01/1970', '13:30', 1, 1),
(2, 'DOMINGO, 17 DE JANEIRO DE 2021', '13:00', 2, 1),
(3, 'DOMINGO, 17 DE JANEIRO DE 2021', '08:00', 3, 3),
(6, 'DOMINGO, 17 DE JANEIRO DE 2021', '14:00', 3, 3),
(7, 'DOMINGO, 17 DE JANEIRO DE 2021', '12:00', 3, 4);

-- --------------------------------------------------------

--
-- Estrutura da tabela `medico`
--

DROP TABLE IF EXISTS `medico`;
CREATE TABLE IF NOT EXISTS `medico` (
  `id` int(15) NOT NULL AUTO_INCREMENT,
  `nome` varchar(150) NOT NULL,
  `cpf` varchar(14) NOT NULL,
  `telefone` varchar(14) NOT NULL,
  `sexo` varchar(20) NOT NULL,
  `endereco` varchar(150) NOT NULL,
  `crm` varchar(10) NOT NULL,
  `especialidade` varchar(150) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `medico`
--

INSERT INTO `medico` (`id`, `nome`, `cpf`, `telefone`, `sexo`, `endereco`, `crm`, `especialidade`) VALUES
(1, 'JEFFERSON', '025,457,106-54', '(31)98714-0014', 'MASCULINO', 'AVENIDA ABC', '31-54967-0', 'CARDIOLOGIA'),
(2, 'CLAUDIO', '316,771,004-71', '(31)98502-4710', 'MASCULINO', 'AVENIDA ANTONIO CARLOS', '16-57410-1', 'PEDIATRIA'),
(3, 'LOURO JOSEFINO', '051,504,644-40', '(31)98108-1058', 'MASCULINO', 'AVENIDA SBT', '05-61051-4', 'DENTISTA'),
(4, 'EDUARDO', '374,961,452-71', '(31)98452-1047', 'MASCULINO', 'AVENIDA AMIGOS DO VERDE', '32-84101-4', 'PEDIATRIA');

-- --------------------------------------------------------

--
-- Estrutura da tabela `paciente`
--

DROP TABLE IF EXISTS `paciente`;
CREATE TABLE IF NOT EXISTS `paciente` (
  `id` int(15) NOT NULL AUTO_INCREMENT,
  `nome` varchar(150) NOT NULL,
  `cpf` varchar(14) NOT NULL,
  `telefone` varchar(14) NOT NULL,
  `sexo` varchar(20) NOT NULL,
  `endereco` varchar(150) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `paciente`
--

INSERT INTO `paciente` (`id`, `nome`, `cpf`, `telefone`, `sexo`, `endereco`) VALUES
(1, 'GABRIEL', '984,651,378-46', '(31)95410-7780', 'MASCULINO', 'AVENIDA JOÃO CÉSAR'),
(2, 'JULIO', '156,405,614-44', '(31)95011-4796', 'MASCULINO', 'AVENIDA CARLOS PRATES'),
(3, 'CARLOS CHAGAS', '987,157,411-00', '(31)98547-1450', 'MASCULINO', 'AVENIDA DAS HORTAS');

-- --------------------------------------------------------

--
-- Estrutura da tabela `prontuario`
--

DROP TABLE IF EXISTS `prontuario`;
CREATE TABLE IF NOT EXISTS `prontuario` (
  `guia` int(11) NOT NULL AUTO_INCREMENT,
  `data` varchar(50) NOT NULL,
  `indicacao` varchar(100) NOT NULL,
  `prioridade` varchar(100) NOT NULL,
  `medicacao` varchar(100) NOT NULL,
  `diabetes` varchar(3) NOT NULL,
  `cardiaco` varchar(3) NOT NULL,
  `hipertenso` varchar(3) NOT NULL,
  `alergia` varchar(3) NOT NULL,
  `fumante` varchar(3) NOT NULL,
  `alcoolismo` varchar(3) NOT NULL,
  `observacao` varchar(100) NOT NULL,
  `idpaciente` int(15) NOT NULL,
  `idmedico` int(15) NOT NULL,
  PRIMARY KEY (`guia`),
  KEY `fk_idpaciente` (`idpaciente`),
  KEY `fk_idmedico` (`idmedico`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `prontuario`
--

INSERT INTO `prontuario` (`guia`, `data`, `indicacao`, `prioridade`, `medicacao`, `diabetes`, `cardiaco`, `hipertenso`, `alergia`, `fumante`, `alcoolismo`, `observacao`, `idpaciente`, `idmedico`) VALUES
(2, 'sábado, 16 de janeiro de 2021', 'PSIQUIÁTRICO', 'ALTA', 'RIVOTRIL', 'SIM', 'SIM', 'SIM', 'SIM', 'SIM', 'SIM', 'SAUDE DEBILITADA', 2, 1),
(5, 'sábado, 16 de janeiro de 2021', 'RECEITA MÉDICA', 'BAIXA', 'CIMEGRIPE', 'SIM', 'SIM', 'NAO', 'NAO', 'NAO', 'SIM', 'TOMAR 2 POR DIA', 1, 1),
(6, 'sábado, 16 de janeiro de 2021', 'INTERNAÇÃO', 'ALTA', 'SORO NA VEIA', 'SIM', 'SIM', 'SIM', 'SIM', 'SIM', 'SIM', 'DEIXAR O PACIENTE TOMANDO SORO DURANTE O DIA', 2, 2),
(7, 'SÁBADO, 16 DE JANEIRO DE 2021', 'RECEITA', 'BAIXA', 'DIPIRONA', 'SIM', 'NAO', 'NAO', 'NAO', 'NAO', 'NAO', 'NÃO PODE TOMAR PARACETAMOL', 2, 1),
(8, 'DOMINGO, 17 DE JANEIRO DE 2021', 'ESTÁVEL', 'MÉDIA', 'DIPIRONA 8 EM 8 HORAS', 'SIM', 'SIM', 'SIM', 'SIM', 'SIM', 'SIM', 'APLICAR BENZETACILL', 3, 1);

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `agendamento`
--
ALTER TABLE `agendamento`
  ADD CONSTRAINT `fk_idmedicoagendamento` FOREIGN KEY (`idmedico`) REFERENCES `medico` (`id`),
  ADD CONSTRAINT `fk_idpacienteagendamento` FOREIGN KEY (`idpaciente`) REFERENCES `paciente` (`id`);

--
-- Limitadores para a tabela `prontuario`
--
ALTER TABLE `prontuario`
  ADD CONSTRAINT `fk_idmedico` FOREIGN KEY (`idmedico`) REFERENCES `medico` (`id`),
  ADD CONSTRAINT `fk_idpaciente` FOREIGN KEY (`idpaciente`) REFERENCES `paciente` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
