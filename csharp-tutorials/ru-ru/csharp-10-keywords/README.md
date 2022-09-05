# Ключевые слова C# 10 (шпаргалка-напоминалка)


```cs
Console.WriteLine("Привет, Мир!");
```
```cs
// Эта шпаргалка-напоминалка предназначена, как краткое описание ключевых слов C# 10, чтобы вспомнить их
```

C\# 10 поддерживает платформа .NET 6.

> Ключевые слова — это предварительно определенные зарезервированные идентификаторы, которые имеют специальные значения для компилятора. Их нельзя использовать как идентификаторы в программах без префикса **@**. Например, допустимым идентификатором является **@if**, но не **if**, поскольку **if** является ключевым словом.

> В первой таблице этой статьи перечислены ключевые слова, которые нельзя использовать как идентификаторы в любой части программы C#. Во второй таблице этой статьи перечислены контекстные ключевые слова C#. Контекстные ключевые слова имеют особое значение только в определенном контексте программы, а за пределами этого контекста могут использоваться в качестве идентификаторов. Как правило, новые ключевые слова добавляются в язык C# в качестве контекстных ключевых слов, чтобы не нарушать работу программ, созданных в предыдущих версиях.

*Заимствовано из документации Microsoft (https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/) от 23.06.2022.*
## Список ключевых слов

| a-e | e-l | n-s | s-w |
| --- | --- | --- | --- |
| [abstract](#abstract) | [event](#event) | [namespace](#namespace) | [static](#static) |
| [as](#as) | [explicit](#explicit) | [new](#new) | [string](#string) |
| [base](#base) | [extern](#extern) | [null](#null) | [struct](#struct) |
| [bool](#bool) | [false](#false) | [object](#object) | [switch](#switch) |
| [break](#break) | [finally](#finally) | [operator](#operator) | [this](#this) |
| [byte](#byte) | [fixed](#fixed) | [out](#out) | [throw](#throw) |
| [case](#case) | [float](#float) | [override](#override) | [true](#true) |
| [catch](#catch) | [for](#for) | [params](#params) | [try](#try) |
| [char](#char) | [foreach](#foreach) | [private](#private) | [typeof](#typeof) |
| [checked](#checked) | [goto](#goto) | [protected](#protected) | [uint](#uint) |
| [class](#class) | [if](#if) | [public](#public) | [ulong](#ulong) |
| [const](#const) | [implicit](#implicit) | [readonly](#readonly) | [unchecked](#unchecked) |
| [continue](#continue) | [in](#in) | [ref](#ref) | [unsafe](#unsafe) |
| [decimal](#decimal) | [int](#int) | [return](#return) | [ushort](#ushort) |
| [default](#default) | [interface](#interface) | [sbyte](#sbyte) | [using](#using) |
| [delegate](#delegate) | [internal](#internal) | [sealed](#sealed) | [virtual](#virtual) |
| [do](#do) | [is](#is) | [short](#short) | [void](#void)  |
| [double](#double) | [lock](#lock) | [sizeof](#sizeof) | [volatile](#volatile) |
| [else](#else) | [long](#long) | [stackalloc](#stackalloc) | [while](#while) |
| [enum](#enum) |  |  |  | 

## Контекстные ключевые слова

| a-f | g-n | n-s | s-y |
| --- | --- | --- | --- |
| [add](#add) | [get](#get) | [notnull](#notnull) | [set](#set) |
| [and](#and) | [global](#global) | [nuint](#nuint) | [unmanaged (соглашение о вызовах указателей функций)](#managed-соглашение-о-вызовах-указателей-функций) |
| [alias](#alias) | [group](#group) | [on](#on) | [unmanaged (ограничение универсального типа)](#unmanaged-ограничение-универсального-типа)) |
| [ascending](#ascending) | [init](#init) | [or](#or) | [value](#value) |
| [args](#args) | [into](#into) | [orderby](#orderby) | [var](#var) |
| [async](#async) | [join](#join) | [partial (тип)](#partial-тип) | [when (условие фильтра)](#when-условие-фильтра) |
| [await](#await) | [let](#let) |  [partial (метод)](#partial-метод) | [where (ограничение универсального типа)](#where-ограничение-универсального-типа) |
| [by](#by) | [managed (соглашение о вызовах указателей функций)](#managed-соглашение-о-вызовах-указателей-функций) | [record](#record) | [where (предложение запроса)](#where-предложение-запроса) |
| [descending](#descending) | [nameof](#nameof) | [remove](#remove) | [with](#with) |
| [dynamic](#dynamic) | [nint](#nint) | [select](#select) | [yield](#yield) |
| [equals](#equals) | [not (не)](#not-не) |  |  | 
| [from](#from) |  |  |  | 


## Список ключевых слов. Описание и примеры

### abstract
Ключевое слово нужно для объявления абстрактного класса и его абстрактых элементов. Абстрактными элементами могут быть: методы, свойства, индексаторы и события. Нельзя создавать экземпляры абстрактного класса.

### as
Оператор **as** нужен для преобразования ссылочных типов или типов поддерживающих *null* значения. Он не вызывает исключения при приведении типов. Вот его эквивалентная запись:
```cs
E as T == E is T ? (T)(E) : (T)null
```

### base
Ключевое слово используется для доступа к членам базового класса в случаях:

	- когда член переопределён;
	- для доступа к конструктору базового класса.

### bool
Ключевое слово для определения булевой переменной. Псевдоним для структуры System.Boolean.

### break

	- оператор используется для преостановки циклов (for, foreach, while или do);
	- оператор используется для завершения элемента в цикле switch.

### byte
Ключевое слово служит для определения однобайтового беззнакового целого числа (от 0 до 255).

### case
Ключевое слово для обозначения подходящего случая для оператора **switch**. Порядок выбора условия оператора проверяется с верху вниз.

### catch
Ключевое слово предназначено для обработки исключения вызванного в блоке **try**. Порядок проверки множества операторов обработки исключений происходит от первого к последнему.

### char
Ключевое слово используется для объявления переменной, которая хранит в себе символ UTF-16 Unicode. Псевдоним для System.Char.

### checked
Оператор для проверки переполнения арифметических операций и операций преобразования.

### class
Ключевое слово предназначено для объявления класса.

### const
Используется для объявления константной переменной или константного поля.

### continue
Ключевое слово предназначено для перехода к следующей итерации цикла (**for**, **foreach**, **while** или **do**).

### decimal
Тип данных с плавающей запятой, самый большой. Занимает 16 байт.

### default
Ключевое слово default можно использовать в следующих контекстах:

	- для указания значения по умолчанию в операторе switch;
	- в качестве оператора или литерала по умолчанию для создания значения по умолчанию для типа данных.
	- в качестве ограничения типа для переопределения универсального метода (where T : default) или явной реализации интерфейса.
	
	
### delegate
Объявление делегата аналогично сигнатуре метода. Он служит, как указатель на метод.

### do
Оператор цикла с постусловием. Выполнятся от одного до нескольких раз. Выполняется пока условие цикла равно **true**.

### double
Тип данных с плавающей запятой, имеет средний размер. Занимает 8 байт.

### else
Ключевое слово используется в операторе **if**, как оператор выполняемый в случае невыполнения условия (ложности условия).

### enum
Тип перечисления, определяемый набором констант целочисленного типа.

### event
Объявления события, типом данных которого является определённый делегат.

### explicit
Определения оператора неявного преобразования (тип данных в текущий класс).

### extern
Ключевое слово используется в объявлении метода с внешней реализацией.

### false
Литерал значения лжи в типе данных bool (System.Boolean).

### finally
Ключевое слово используется в опреаторе try-catch-finally для завершения обработки исключения или блока try.

### fixed
Ключевое слово создает блок кода с указателем на управляемую переменную и "закрепляет" эту переменную во время выполнения оператора.

### float
Тип данных с плавающей запятой, имеет наименьший размер. Занимает 4 байта.

### for
Объявление цикла "со счётчиком".

### foreach
Цикл для перебора элементов *System.Collections.IEnumerable* или *System.Collections.Generic.IEnumerable\<T\>*.

### goto
Оператор перехода к метке.

### if
Оператор проверки условия. Блок кода оператора выполняется, когда условие истинно (**true**).

### implicit
Определение оператора явного преобразования (текущий класс в тип данных).

### in
Ключевое слово in используется в следующих случаях:

	- Цикл foreach, для определения перебераемого экземпляра коллекции. 
	- Параметры универсального типа в универсальных интерфейсах и делегатах, для определения контравариантного параметра.
	- В качестве модификатора параметра, для задания его непереопределяемым/входным.
	- В запосах LINQ, совместно с ключевым словом join.
	- В запосах LINQ, совместно с ключевым словом from.

### int
Тип данных, представляющий собой 32-разрядное целое число со знаком (*System.Int32*).

### interface
Ключевое слово для определения интерфейса. Интерфейс преставляет собой договор для классов/стуктур для соглашения об их членах.

### internal
Ключевое слово используется для ограничения доступа. Оно используется в следующих уровнях доступа:

	- internal - доступ ограничивается текущей сборкой;
	- protected internal - доступ ограничивается текущей сборкой или типами, которые являются производными от содержащего класса.

### is
Оператор проверки типа. Проверяет, совместим ли результат выражения с указанным типом. Возвращает **true** или **false**.

### lock
Оператор блокировки доступа к объекту. Опертор блокирует объект для других параллельных выполнений, где также использается этот оператор с таким же объектом. 

### long
Тип данных, представляющий собой 64-разрядное целое число со знаком (*System.Int64*).

### namespace
Ключевое слово для объявления пространства имён.

### new

	- Опрератор new используется для создания экземпляра типа;
	- Используется, как ограничение универсального типа, о том что агрумент типа должен иметь конструктор поумолчанию.

### null
Ссылка, которая не ссылается на объект. Может присваиваться для начальной инициализации объектам.

### object
Базовый тип данных для объектов. Является псевдонимом *System.Object*.

### operator
Ключевое слово для перегрузки операторов.

### out
Ипользуется:

	- для передачи параметра по ссылке, а не по значению. Представляет собой выходной параметр;
	- для обозначения ковариантных параметров в универсальных типах для интерфейсов и делегатов.

### override
Модификатор override нужен для переопределения абстрактной или виртуальной реализации унаследанного метода, свойства, индексатора, события.

### params
Ключевое слово для задания массива параметров определённого типа. Это переменное число параметров. Когда параметры не передаются, то передаётся массив нулевого размера. Параметры можно передавать через запятую или в массиве тогоже типа.

### private
Ключевое слово используется в двух модификаторах доступа:

	- private - lоступ к типу или члену возможен в том же типе реализации класса или структуры (class, struct);
	- private protected - то же самое, что и private, но доступ к типу или элементу возможен из типов, производных от объекта class и объявляемых в сборке, содержащей этот объект.

### protected
Ключевое слово используется в трёх модификаторах доступа:

	- protected - доступ из этого же класса или производного;
	- protected internal - используется, как предыдущий уровень доступа (protected), но доступ так же доступен из текущей сборки;
	- private protected - доступ для производных классов, но в тойже сборке.

### public
Модификатор доступа к типам и их членам с максимальным уровнем доступа, видим всему.

### readonly
Ключевое слово, которое может использоваться в четырёх контекстах:

	- поле только для чтения. Присваение может происходить сколько угодно раз при объявлении или конструкторе;
	- при объявлении структуры, объявление readonly struct определяет, то что структура является неизменяемой;
	- при объявлении членой не изменяемой структуры;
	- при возвращении значения методом модификатор ref readonly указывает, что ссылка является не изменяемой. 

### ref
Ключевое слово **ref** указывает на то, что значение передается по ссылке. Оно используется в четырех разных ситуациях:

	- при передаче параметров в метод по ссылке;
	- для возвращения методом значения по ссылке;
	- в ссылочных локальных переменных;
	- в объявлении структуры, чтобы указать, что она хранится в стеке.

### return
Используется для завершения функции или возвращения ею результата.

### sbyte
Ключевое слово используется для обозначения знакового однобайтового целого числа (от -128 до 127).

### sealed
Модификатор класса, запрещающий наследовать этот класс.

### short
Тип данных для представления 16-разрядного целого числа со знаком (от -32 768 до 32 767).

### sizeof
Опратор для определения числа байт занимаемых переменной.

### stackalloc
Ключевое слово **stackalloc** выделяет блок памяти в стеке.

### static
Испольуется для:

	- объявления статических членов;
	- объявления статических классов;
	- в операторе импорта using static, для импорта элементов static из одного типа.

### string
Ссылояный тип данных для представления строк (последовательностей символов), является псевдонимом для *System.String*.

### struct
Ключевое слово для создания структуры.

### switch
Оператор выбора.

### this
Ссылка на текущий экземпляр класса.

### throw
Ключевое слово для генерации исключения.

### true
Значение истины типа **bool**.

### try
Оператор для объявления блока, в котором перехватывается исключение.

### typeof
Оператор для получения System.Type для указанного типа, т.е. получение типа.

### uint
Целочисленный тип данных для представлени 32-разрядного числа без знака (от 0 до 4 294 967 295).

### ulong
Целочисленный тип данных для представлени 64-разрядного числа без знака (от 0 до 18 446 744 073 709 551 615).

### unchecked
Данная инструкция отключает проверку переполнения при арифметических операциях и преобразованиях целочисленных чисел.

### unsafe
Ключевое слово unsafe обозначает небезопасный контекст, необходимый для выполнения любых операций с применением указателей.

### ushort
Целочисленный тип данных для представлени 16-разрядного числа без знака (от 0 до 65 535).

### using
Ключевое слово **using** используется в двух случаях:

	- импорт простанства имён;
	- объявление блока кода, с освобождением по окончаию ресурсов переменной.

### virtual
Ключевое слово **virtual** используется для объявления методов, свойств, индексаторов и событий и разрешения их переопределения в производном классе. 

### void
Используется для того, чтобы обозначить метод, который не возвращает значение.

### volatile
Ключевое слово **volatile** помечает поле и позволяет изменять его нескольким потокам, выполняемых одновременно.

### while
Цикл с предусловием.

## Контекстные ключевые слова. Описание и примеры

### add
[Документация Microsoft - add](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/add)

### and
[Документация Microsoft - and](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/patterns#logical-patterns)

### alias
[Документация Microsoft - alias](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/extern-alias)

### ascending
[Документация Microsoft - ascending](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/ascending)

### args
[Документация Microsoft - args](https://docs.microsoft.com/ru-ru/dotnet/csharp/fundamentals/program-structure/top-level-statements#args)

### async
[Документация Microsoft - async](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/async)

### await
[Документация Microsoft - await](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/await)

### by
[Документация Microsoft - by](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/by)

### descending
[Документация Microsoft - descending](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/descending)

### dynamic
[Документация Microsoft - dynamic](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/reference-types)

### equals
[Документация Microsoft - equals](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/equals)

### from
[Документация Microsoft - from](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/from-clause)

### get
[Документация Microsoft - get](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/get)

### global
[Документация Microsoft - global](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/namespace-alias-qualifier)

### group
[Документация Microsoft - group](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/group-clause)

### init
[Документация Microsoft - init](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/init)

### into
[Документация Microsoft - into](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/into)

### join
[Документация Microsoft - join](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/join-clause)

### let
[Документация Microsoft - let](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/let-clause)

### managed (соглашение о вызовах указателей функций)
[Документация Microsoft - managed (соглашение о вызовах указателей функций)](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/unsafe-code#function-pointers)

### nameof
[Документация Microsoft - nameof](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/nameof)

### nint
[Документация Microsoft - nint](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/integral-numeric-types)

### not (не)
[Документация Microsoft - not (не)](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/patterns#logical-patterns)

### notnull
[Документация Microsoft - notnull](https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters#notnull-constraint)

### nuint
[Документация Microsoft - nuint](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/integral-numeric-types)

### on
[Документация Microsoft - on](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/on)

### or
[Документация Microsoft - or](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/patterns#logical-patterns)

### orderby
[Документация Microsoft - orderby](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/orderby-clause)

### partial (тип)
[Документация Microsoft - partial (тип)](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/partial-type)

### partial (метод)
[Документация Microsoft - partial (метод)](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/partial-method)

### record
[Документация Microsoft - record](https://docs.microsoft.com/ru-ru/dotnet/csharp/fundamentals/types/records)

### remove
[Документация Microsoft - remove](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/remove)

### select
[Документация Microsoft - select](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/select-clause)

### set
[Документация Microsoft - set](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/set)

### unmanaged (соглашение о вызовах указателей функций)
[Документация Microsoft - unmanaged (соглашение о вызовах указателей функций)](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/unsafe-code#function-pointers)

### unmanaged (ограничение универсального типа)
[Документация Microsoft - unmanaged (ограничение универсального типа)](https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters#unmanaged-constraint)

### value
[Документация Microsoft - value](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/value)

### var
[Документация Microsoft - var](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/var)

### when (условие фильтра)
[Документация Microsoft - when (условие фильтра)](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/when)

### where (ограничение универсального типа)
[Документация Microsoft - where (ограничение универсального типа)](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/where-generic-type-constraint)

### where (предложение запроса)
[Документация Microsoft - where (предложение запроса)](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/where-clause)

### with
[Документация Microsoft - with](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/with-expression)

### yield
[Документация Microsoft - yield](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/yield)


