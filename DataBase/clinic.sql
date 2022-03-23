-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Мар 22 2022 г., 02:30
-- Версия сервера: 8.0.19
-- Версия PHP: 7.4.5

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `clinic`
--

-- --------------------------------------------------------

--
-- Структура таблицы `diseases`
--

CREATE TABLE `diseases` (
  `ID` int NOT NULL,
  `disease` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `diseases`
--

INSERT INTO `diseases` (`ID`, `disease`) VALUES
(1, 'Повышенное давление ');

-- --------------------------------------------------------

--
-- Структура таблицы `offices`
--

CREATE TABLE `offices` (
  `ID` int NOT NULL,
  `office` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `offices`
--

INSERT INTO `offices` (`ID`, `office`) VALUES
(1, 1),
(2, 2);

-- --------------------------------------------------------

--
-- Структура таблицы `problems`
--

CREATE TABLE `problems` (
  `ID` int NOT NULL,
  `problem` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `problems`
--

INSERT INTO `problems` (`ID`, `problem`) VALUES
(1, 'Головная боль'),
(2, 'Боль в животе'),
(3, 'Боль в ноге'),
(4, 'Боль в глазах');

-- --------------------------------------------------------

--
-- Структура таблицы `reference`
--

CREATE TABLE `reference` (
  `ID` int NOT NULL,
  `Name_doc` varchar(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `disease` varchar(100) NOT NULL,
  `time_beginning` date NOT NULL,
  `time_end` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `request`
--

CREATE TABLE `request` (
  `ID` int NOT NULL,
  `Name` varchar(100) NOT NULL,
  `disease` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `type` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `request`
--

INSERT INTO `request` (`ID`, `Name`, `disease`, `Email`, `type`) VALUES
(1, 'wqe', 'qwe', 'ww', 'ЛОР'),
(2, 'eqw', 'se', 'eqwq', 'Терапевт'),
(3, 'ывавы', 'Головная боль', 'выа', 'ЛОР'),
(4, 'ывавыыфвфы', 'Боль в животе', 'выафывфы', 'терапевт'),
(5, 'ывавыыфвфывфц', 'Боль в глазах', 'выафывфыфв', 'Венеролог');

-- --------------------------------------------------------

--
-- Структура таблицы `ticket`
--

CREATE TABLE `ticket` (
  `ID` int NOT NULL,
  `Name` varchar(100) NOT NULL,
  `office` int NOT NULL,
  `time` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `ticket`
--

INSERT INTO `ticket` (`ID`, `Name`, `office`, `time`, `email`) VALUES
(312, 'пыв', 223, '2022-12-12', 'уйуцуй3'),
(313, 'dad', 1, '8 января 2022 г.', 'System.Windows.Forms.ComboBox, Items.Count: 2'),
(314, 'dad', 2, '7 января 2022 г.', 'ww'),
(315, 'cxz', 1, '22 марта 2022 г.', 'выафывфыфв');

-- --------------------------------------------------------

--
-- Структура таблицы `user`
--

CREATE TABLE `user` (
  `ID` int NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Keyd` varchar(100) NOT NULL,
  `Type` varchar(100) NOT NULL,
  `Root` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `user`
--

INSERT INTO `user` (`ID`, `Name`, `Keyd`, `Type`, `Root`) VALUES
(1, 'ad', 'ad', 'ad', 2),
(2, 'dad', 'w', 'w', 1),
(32, 'ads', 'qq', 'dd', 3),
(33, 'asdw', 'ww', 'das', 4),
(34, 'cxz', 'ee', 'dase', 5);

-- --------------------------------------------------------

--
-- Структура таблицы `аллерголог`
--

CREATE TABLE `аллерголог` (
  `ID` int NOT NULL,
  `Name` varchar(100) NOT NULL,
  `disease` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf16;

-- --------------------------------------------------------

--
-- Структура таблицы `венеролог`
--

CREATE TABLE `венеролог` (
  `ID` int NOT NULL,
  `Name` varchar(100) NOT NULL,
  `disease` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `венеролог`
--

INSERT INTO `венеролог` (`ID`, `Name`, `disease`, `Email`) VALUES
(1, 'ывавыыфвфывфц', 'Боль в глазах', 'выафывфыфв');

-- --------------------------------------------------------

--
-- Структура таблицы `лор`
--

CREATE TABLE `лор` (
  `ID` int NOT NULL,
  `Name` varchar(100) NOT NULL,
  `disease` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `лор`
--

INSERT INTO `лор` (`ID`, `Name`, `disease`, `Email`) VALUES
(1, 'ывавы', 'Головная боль', 'выа');

-- --------------------------------------------------------

--
-- Структура таблицы `терапевт`
--

CREATE TABLE `терапевт` (
  `ID` int NOT NULL,
  `Name` varchar(100) NOT NULL,
  `disease` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `терапевт`
--

INSERT INTO `терапевт` (`ID`, `Name`, `disease`, `Email`) VALUES
(1, 'ывавыыфвфы', 'Боль в животе', 'выафывфы');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `diseases`
--
ALTER TABLE `diseases`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `offices`
--
ALTER TABLE `offices`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `problems`
--
ALTER TABLE `problems`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `reference`
--
ALTER TABLE `reference`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `request`
--
ALTER TABLE `request`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `ticket`
--
ALTER TABLE `ticket`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `аллерголог`
--
ALTER TABLE `аллерголог`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `венеролог`
--
ALTER TABLE `венеролог`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `лор`
--
ALTER TABLE `лор`
  ADD PRIMARY KEY (`ID`);

--
-- Индексы таблицы `терапевт`
--
ALTER TABLE `терапевт`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `diseases`
--
ALTER TABLE `diseases`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `offices`
--
ALTER TABLE `offices`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `problems`
--
ALTER TABLE `problems`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `request`
--
ALTER TABLE `request`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `ticket`
--
ALTER TABLE `ticket`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=316;

--
-- AUTO_INCREMENT для таблицы `user`
--
ALTER TABLE `user`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT для таблицы `аллерголог`
--
ALTER TABLE `аллерголог`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `венеролог`
--
ALTER TABLE `венеролог`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `лор`
--
ALTER TABLE `лор`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT для таблицы `терапевт`
--
ALTER TABLE `терапевт`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
