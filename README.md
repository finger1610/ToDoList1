#ToDoList
##Что нужно сделать:
За основу решил взять стандартный самсунговский заметочник в формате десктопного приложения на винде (WPF. C#).

поле со списком дел, внизу кнопка "+" добавляешь текстовую заметку (через всплывающее окно с текстовым полем), сохраняешь. Задачка появляется в поле с другими делами. Слева от заметки чек-бокс (по умолчанию после создания выключен).

По нажатию на текст задачки она раскрывает весь текст, который не влез при текущей ширине окна. Двойной клик на текст - переход к редактированию (через октрытиие всплыващего окна). По нажатию на чек-бокс заметка зачеркивается - задачка отмечается выполненной. Повторное нажатие делает снова задачу активной.

через правую кнопку мыши контекстное меню для клонирования, редактирования или удаления задачи.

Потом хочу прибить хранение списка дел в БДшке (MS QSL), возможно когда-нибудь прибить авторизацию ( с сохранением защиты передачи пароля в БД и хранение данных пользователя в зашифрованном виде), чтоб разными пользователями можно было делать свои заметки и делиться между пользователями. После создания авторизации и пользователей прибить логирование всех действий пользователя.

добавить функционал администратора. Пока не понял где и как. Возможно, при авторизации под admin будет расширенный функционал todoList с чтением логов (по пользователям) и смены прав для других пользователей и назначение админов.

Когда и это станет посильным, научу приложение снюхиваться с гугл календарем, чтобы он туда кидал задачки на конкретный день.

а потом, когда совсем ебанусь в край и познаю программирование, запилю это не на WPF, а прям веб приложуху на ASP Net.