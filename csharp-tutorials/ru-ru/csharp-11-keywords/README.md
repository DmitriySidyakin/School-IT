[Главная](https://dmitriysidyakin.github.io/School-IT/)

# Ключевые слова C# 11 (шпаргалка-напоминалка)

```cs
Console.WriteLine("Привет, Мир! Это ключевые слова C# 11.");
```
```cs
// Эта шпаргалка-напоминалка предназначена, как краткое описание ключевых слов C# 11, чтобы вспомнить их
```

C\# 11 поддерживает платформа .NET 7.

> Ключевые слова — это предварительно определенные зарезервированные идентификаторы, которые имеют специальные значения для компилятора. Их нельзя использовать как идентификаторы в программах без префикса **@**. Например, допустимым идентификатором является **@if**, но не **if**, поскольку **if** является ключевым словом.

> В первой таблице этой статьи перечислены ключевые слова, которые нельзя использовать как идентификаторы в любой части программы C#. Во второй таблице этой статьи перечислены контекстные ключевые слова C#. Контекстные ключевые слова имеют особое значение только в определенном контексте программы, а за пределами этого контекста могут использоваться в качестве идентификаторов. Как правило, новые ключевые слова добавляются в язык C# в качестве контекстных ключевых слов, чтобы не нарушать работу программ, созданных в предыдущих версиях.

*Список ключевых слов заимствован из документации Microsoft (https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/)*

## Список ключевых слов

[abstract](#abstract)
[as](#as)
[base](#base)
[bool](#bool)
[break](#break)
[byte](#byte)
[case](#case)
[catch](#catch)
[char](#char)
[checked](#checked)
[class](#class)
[const](#const)
[continue](#continue)
[decimal](#decimal)
[default](#default)
[delegate](#delegate)
[do](#do)
[double](#double)
[else](#else)
[enum](#enum)
[event](#event)
[explicit](#explicit)
[extern](#extern)
[false](#false)
[finally](#finally)
[fixed](#fixed)
[float](#float)
[foreach](#foreach)
[goto](#goto)
[if](#if)
[implicit](#implicit)
[in](#in)
[int](#int)
[interface](#interface)
[internal](#internal)
[is](#is)
[lock](#lock)
[long](#long)
[namespace](#namespace)
[new](#new)
[null](#null)
[object](#object)
[operator](#operator)
[out](#out)
[override](#override)
[params](#params)
[private](#private)
[protected](#protected)
[public](#public)
[readonly](#readonly)
[ref](#ref)
[return](#return)
[sbyte](#sbyte)
[sealed](#sealed)
[short](#short)
[sizeof](#sizeof)
[stackalloc](#stackalloc)
[static](#static)
[string](#string)
[struct](#struct)
[switch](#switch)
[this](#this)
[throw](#throw)
[true](#true)
[try](#try)
[typeof](#typeof)
[uint](#uint)
[ulong](#ulong)
[unchecked](#unchecked)
[unsafe](#unsafe)
[ushort](#ushort)
[using](#using)
[virtual](#virtual)
[void](#void)
[volatile](#volatile)
[while](#while)


## Контекстные ключевые слова

[add](#add)
[alias](#alias)
[and](#and)
[args](#args)
[ascending](#ascending)
[async](#async)
[await](#await)
[by](#by)
[descending](#descending)
[dynamic](#dynamic)
[equals](#equals)
[file](#file)
[from](#from)
[get](#get)
[global](#global)
[group](#group)
[init](#init)
[into](#into)
[join](#join)
[let](#let)
[managed (соглашение вызова указателя функции)](#managedсоглашение-вызова-указателя-функции)
[nameof](#nameof)
[nint](#nint)
[not](#not)
[notnull](#notnull)
[nuint](#nuint)
[on](#on)
[or](#or)
[orderby](#orderby)
[partial (метод)](#partialметод)
[partial (тип)](#partialтип)
[record](#record)
[remove](#remove)
[required](#required)
[scoped](#scoped)
[select](#select)
[set](#set)
[unmanaged (соглашение вызова указателя функции)](#unmanagedсоглашение-вызова-указателя-функции)
[unmanaged (ограничение обобщённого типа)](#unmanagedограничение-обобщённого-типа)
[value](#value)
[var](#var)
[when](#when)
[where (ограничение обобщённого типа)](#whereограничение-обобщённого-типа)
[where (выражение запроса)](#whereвыражение-запроса)
[with](#with)
[yield](#yield)



## Список ключевых слов. Описание и примеры

[В написании...]

### abstract

Ключевое слово нужно для объявления абстрактного класса и его абстрактых элементов.

Модификатор *abstract* указывает, что изменяемый элемент имеет отсутствующую или неполную реализацию. Модификатор abstract можно использовать с классами, методами, свойствами, индексаторами и событиями.

Класс помеченный ключевым словом *abstract* имеет не полную реализацию. Элементы класса помеченные этим словом, означают, что они должны быть реализованы в наследнике. Нельзя создавать экземпляры абстрактного класса.

```cs

    abstract class Shape
    {
        public abstract double GetArea();
    }

    class Circle : Shape
    {
        private int _r;

        public Circle(int radius) => _r = radius;

        public override double GetArea() => Math.PI * _r * _r;
    }
	
```

### as

Оператор as нужен для преобразования ссылочных типов или типов поддерживающих null значения. Он не вызывает исключения при приведении типов. Вот его эквивалентная запись:

```cs

E as T == E is T ? (T)(E) : (T)null

```

### base

Ключевое base слово используется для доступа к членам базового класса из производного класса в случаях:

- когда член переопределён;
- для доступа к конструктору базового класса.

### bool

Ключевое слово для определения булевой переменной. Псевдоним для структуры System.Boolean.

Значение по умолчанию для типа bool: false.

```cs

bool _checked = true;

Console.WriteLine(_checked ? "Проверено" : "Не проверено");

```

### break

- оператор используется для преостановки циклов (for, foreach, while или do);
- оператор используется для завершения элемента в цикле switch.

Пример в цикле foreach:

```cs

foreach(var e in Elems)
{
	if(e.IsFinal)
		break;
}

```

### byte

Ключевое слово служит для определения однобайтового беззнакового целого числа (от 0 до 255).

### case

Ключевое слово для обозначения подходящего случая для оператора switch. Порядок выбора условия оператора проверяется с верху вниз.

### catch

Ключевое слово предназначено для обработки исключения вызванного в блоке try. Порядок проверки множества операторов обработки исключений происходит от первого к последнему.

```cs

try
{
    ...
}
catch (Exception e)
{
    Console.WriteLine($"Failed: {e.Message}");
}

```

### char

### checked

### class

### const

### continue

### decimal

### default

### delegate

### do

### double

### else

### enum 

### event

### explicit

### extern

### false

### finally

### fixed

### float

### foreach

### goto

### if

### implicit

### in

### int

### interface

### internal

### is

### lock

### long

### namespace

### new

### null

### object

### operator

### out

### override

### params

### private

### protected

### public

### readonly

### ref

### return

### sbyte

### sealed

### short

### sizeof

### stackalloc

### static

### string

### struct

### switch

### this

### throw

### true

### try

### typeof

### uint

### ulong

### unchecked

### unsafe

### ushort

### using

### virtual

### void

### volatile

### while



## Контекстные ключевые слова. Описание и примеры

[В написании...]

### add

### and

### alias

### ascending

### args

### async

### await

### by

### descending

### dynamic

### equals

### file

### from

### get

### global

### group

### init

### into

### join

### let

### managed (соглашение вызова указателя функции)

### nameof

### nint

### not

### notnull

### nuint

### on

### or

### orderby

### partial (метод)

### partial (тип)

### record

### remove

### required

### scoped

### select

### set

### unmanaged (соглашение вызова указателя функции)

### unmanaged (ограничение обобщённого типа)

### value

### var

### when

### where (ограничение обобщённого типа)

### where (выражение запроса)

### with

### yield 
