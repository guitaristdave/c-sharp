Знакомство с языками программирования (C#)
-----------------------------------------------

### Практическая часть (семинары)
- Используемая [библиотека классов](https://github.com/crasher307/c-sharp/tree/master/func)
- Урок 1. Знакомство с языком программирования С#
	- [работа во время семинара](https://github.com/crasher307/c-sharp/tree/master/lesson1/work)
	- [домашнее задание](https://github.com/crasher307/c-sharp/tree/master/lesson1/homework)
- Урок 2. Массивы и функции в программировании
	- [работа во время семинара](https://github.com/crasher307/c-sharp/tree/master/lesson2/work)
	- [домашнее задание](https://github.com/crasher307/c-sharp/tree/master/lesson2/homework)
- Урок 3. Массивы и функции в программировании
	- [работа во время семинара](https://github.com/crasher307/c-sharp/tree/master/lesson3/work)
- Урок 4. Функции продолжение
	- [работа во время семинара](https://github.com/crasher307/c-sharp/tree/master/lesson4/work)

<br>

#### Bash скрипты для создания/запуска проектов
- [create.sh](https://github.com/crasher307/c-sharp/blob/master/start.sh) - создает или запускает проект
- bash
	- [createLesson.sh](https://github.com/crasher307/c-sharp/blob/master/bash/createLesson.sh) - создает папки урока/проекта `sh bash/createLesson.sh $gitFolder $lessonNumber`
	- [createProject.sh](https://github.com/crasher307/c-sharp/blob/master/bash/createProject.sh) - создает проект `sh bash/createProject.sh $gitFolder $lessonNumber <"work"|"homework"> $projectNumber"`
	- [runProject.sh](https://github.com/crasher307/c-sharp/blob/master/bash/runProject.sh) - запускает проект `sh bash/createProject.sh $gitFolder $lessonNumber <"work"|"homework"> $projectNumber"`

<br>

```bash
sh start.sh # создание/запуск проекта (парамеры вводятся по ходу)

# DotNet
dotnet new console                            # новый проект
dotnet new classlib                           # новая библиотека классов
dotnet add reference "<folder>/<file>.csproj" # подключить библиотеку
dotnet run                                    # запуск проекта
```