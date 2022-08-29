# Ключевые слова C# 10


```cs
Console.WriteLine("Привет, Мир!");
```
```cs
// Эта книга предназначена для того, чтобы дать представление обо всех ключевых словах C# 10
```
```cs
// Она подойдёт, как справочник по ключевым словам C# 10, как начинающим специалистам, так и опытным для повторения
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
[Документация Microsoft - abstract](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/abstract)

### as
[Документация Microsoft - as](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/type-testing-and-cast#as-operator)

### base
[Документация Microsoft - base](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/base)

### bool
[Документация Microsoft - bool](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/bool)

### break
[Документация Microsoft - break](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/statements/jump-statements#the-break-statement)

### byte
[Документация Microsoft - byte](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/integral-numeric-types)

### case
[Документация Microsoft - case](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/statements/selection-statements#the-switch-statement)

### catch
[Документация Microsoft - catch](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/try-catch)

### char
[Документация Microsoft - char](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/char)

### checked
[Документация Microsoft - checked](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/checked)

### class
[Документация Microsoft - class](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/class)

### const
[Документация Microsoft - const](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/const)

### continue
[Документация Microsoft - continue](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/statements/jump-statements#the-continue-statement)

### decimal
[Документация Microsoft - decimal](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types)

### default
[Документация Microsoft - default](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/default)

### delegate
[Документация Microsoft - delegate](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/reference-types)

### do
[Документация Microsoft - do](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/statements/iteration-statements#the-do-statement)

### double
[Документация Microsoft - double](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types)

### else
[Документация Microsoft - else](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/statements/selection-statements#the-if-statement)

### enum
[Документация Microsoft - enum](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/enum)

### event
[Документация Microsoft - event](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/event)

### explicit
[Документация Microsoft - explicit](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/user-defined-conversion-operators)

### extern
[Документация Microsoft - extern](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/extern)

### false
[Документация Microsoft - false](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/bool)

### finally
[Документация Microsoft - finally](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/try-finally)

### fixed
[Документация Microsoft - fixed](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/fixed-statement)

### float
[Документация Microsoft - float](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types)

### for
[Документация Microsoft - for](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/statements/iteration-statements#the-for-statement)

### foreach
[Документация Microsoft - foreach](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/statements/iteration-statements#the-foreach-statement)

### goto
[Документация Microsoft - goto](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/statements/jump-statements#the-goto-statement)

### if
[Документация Microsoft - if](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/statements/selection-statements#the-if-statement)

### implicit
[Документация Microsoft - implicit](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/user-defined-conversion-operators)

### in
[Документация Microsoft - in](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/in)

### int
[Документация Microsoft - int](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/integral-numeric-types)

### interface
[Документация Microsoft - interface](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/interface)

### internal
[Документация Microsoft - internal](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/internal)

### is
[Документация Microsoft - is](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/is)

### lock
[Документация Microsoft - lock](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/statements/lock)

### long
[Документация Microsoft - long](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/integral-numeric-types)

### namespace
[Документация Microsoft - namespace](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/namespace)

### new
[Документация Microsoft - new](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/new-operator)

### null
[Документация Microsoft - null](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/null)

### object
[Документация Microsoft - object](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/reference-types)

### operator
[Документация Microsoft - operator](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/operator-overloading)

### out
[Документация Microsoft - out](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/out)

### override
[Документация Microsoft - override](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/override)

### params
[Документация Microsoft - params](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/params)

### private
[Документация Microsoft - private](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/private)

### protected
[Документация Microsoft - protected](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/protected)

### public
[Документация Microsoft - public](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/public)

### readonly
[Документация Microsoft - readonly](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/readonly)

### ref
[Документация Microsoft - ref](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/ref)

### return
[Документация Microsoft - return](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/statements/jump-statements#the-return-statement)

### sbyte
[Документация Microsoft - sbyte](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/integral-numeric-types)

### sealed
[Документация Microsoft - sealed](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/sealed)

### short
[Документация Microsoft - short](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/sizeof)

### sizeof
[Документация Microsoft - sizeof](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/sizeof)

### stackalloc
[Документация Microsoft - stackalloc](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/stackalloc)

### static
[Документация Microsoft - static](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/static)

### string
[Документация Microsoft - string](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/reference-types)

### struct
[Документация Microsoft - struct](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/struct)

### switch
[Документация Microsoft - switch](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/switch-expression)

### this
[Документация Microsoft - this](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/this)

### throw
[Документация Microsoft - throw](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/throw)

### true
[Документация Microsoft - true](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/bool)

### try
[Документация Microsoft - try](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/try-catch)

### typeof
[Документация Microsoft - typeof](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/type-testing-and-cast#typeof-operator)

### uint
[Документация Microsoft - uint](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/integral-numeric-types)

### ulong
[Документация Microsoft - ulong](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/integral-numeric-types)

### unchecked
[Документация Microsoft - unchecked](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/unchecked)

### unsafe
[Документация Microsoft - unsafe](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/unsafe)

### ushort
[Документация Microsoft - ushort](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/integral-numeric-types)

### using
[Документация Microsoft - using](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/using)

### virtual
[Документация Microsoft - virtual](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/virtual)

### void
[Документация Microsoft - void](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/builtin-types/void)

### volatile
[Документация Microsoft - volatile](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/keywords/volatile)

### while
[Документация Microsoft - while](https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement)

## Контекстные ключевые слова. Описание и примеры

### add
[Документация Microsoft - add]()

### and
[Документация Microsoft - and]()

### alias
[Документация Microsoft - alias]()

### ascending
[Документация Microsoft - ascending]()

### args
[Документация Microsoft - args]()

### async
[Документация Microsoft - async]()

### await
[Документация Microsoft - await]()

### by
[Документация Microsoft - by]()

### descending
[Документация Microsoft - descending]()

### dynamic
[Документация Microsoft - dynamic]()

### equals
[Документация Microsoft - equals]()

### from
[Документация Microsoft - from]()

### get
[Документация Microsoft - get]()

### global
[Документация Microsoft - global]()

### group
[Документация Microsoft - group]()

### init
[Документация Microsoft - init]()

### into
[Документация Microsoft - into]()

### join
[Документация Microsoft - join]()

### let
[Документация Microsoft - let]()

### managed (соглашение о вызовах указателей функций)
[Документация Microsoft - managed (соглашение о вызовах указателей функций)]()

### nameof
[Документация Microsoft - nameof]()

### nint
[Документация Microsoft - nint]()

### not (не)
[Документация Microsoft - not (не)]()

### notnull
[Документация Microsoft - notnull]()

### nuint
[Документация Microsoft - nuint]()

### on
[Документация Microsoft - on]()

### or
[Документация Microsoft - or]()

### orderby
[Документация Microsoft - orderby]()

### partial (тип)
[Документация Microsoft - partial (тип)]()

### partial (метод)
[Документация Microsoft - partial (метод)]()

### record
[Документация Microsoft - record]()

### remove
[Документация Microsoft - remove]()

### select
[Документация Microsoft - select]()

### set
[Документация Microsoft - set]()

### unmanaged (соглашение о вызовах указателей функций)
[Документация Microsoft - nmanaged (соглашение о вызовах указателей функций)]()

### unmanaged (ограничение универсального типа)
[Документация Microsoft - unmanaged (ограничение универсального типа)]()

### value
[Документация Microsoft - value]()

### var
[Документация Microsoft - var]()

### when (условие фильтра)
[Документация Microsoft - when (условие фильтра)]()

### where (ограничение универсального типа)
[Документация Microsoft - where (ограничение универсального типа)]()

### where (предложение запроса)
[Документация Microsoft - where (предложение запроса)]()

### with
[Документация Microsoft - with]()

### yield
[Документация Microsoft - yield]()


