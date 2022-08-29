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
[Документация Microsoft - checked]()

### class
[Документация Microsoft - class]()

### const
[Документация Microsoft - const]()

### continue
[Документация Microsoft - continue]()

### decimal
[Документация Microsoft - decimal]()

### default
[Документация Microsoft - default]()

### delegate
[Документация Microsoft - delegate]()

### do
[Документация Microsoft - do]()

### double
[Документация Microsoft - double]()

### else
[Документация Microsoft - else]()

### enum
[Документация Microsoft - enum]()

### event
[Документация Microsoft - event]()

### explicit
[Документация Microsoft - explicit]()

### extern
[Документация Microsoft - extern]()

### false
[Документация Microsoft - false]()

### finally
[Документация Microsoft - finally]()

### fixed
[Документация Microsoft - fixed]()

### float
[Документация Microsoft - float]()

### for
[Документация Microsoft - for]()

### foreach
[Документация Microsoft - foreach]()

### goto
[Документация Microsoft - goto]()

### if
[Документация Microsoft - if]()

### implicit
[Документация Microsoft - implicit]()

### in
[Документация Microsoft - in]()

### int
[Документация Microsoft - int]()

### interface
[Документация Microsoft - interface]()

### internal
[Документация Microsoft - internal]()

### is
[Документация Microsoft - is]()

### lock
[Документация Microsoft - lock]()

### long
[Документация Microsoft - long]()

### namespace
[Документация Microsoft - namespace]()

### new
[Документация Microsoft - new]()

### null
[Документация Microsoft - null]()

### object
[Документация Microsoft - object]()

### operator
[Документация Microsoft - operator]()

### out
[Документация Microsoft - out]()

### override
[Документация Microsoft - override]()

### params
[Документация Microsoft - params]()

### private
[Документация Microsoft - private]()

### protected
[Документация Microsoft - protected]()

### public
[Документация Microsoft - public]()

### readonly
[Документация Microsoft - readonly]()

### ref
[Документация Microsoft - ref]()

### return
[Документация Microsoft - return]()

### sbyte
[Документация Microsoft - sbyte]()

### sealed
[Документация Microsoft - sealed]()

### short
[Документация Microsoft - short]()

### sizeof
[Документация Microsoft - sizeof]()

### stackalloc
[Документация Microsoft - stackalloc]()

### static
[Документация Microsoft - static]()

### string
[Документация Microsoft - string]()

### struct
[Документация Microsoft - struct]()

### switch
[Документация Microsoft - switch]()

### this
[Документация Microsoft - this]()

### throw
[Документация Microsoft - throw]()

### true
[Документация Microsoft - true]()

### try
[Документация Microsoft - try]()

### typeof
[Документация Microsoft - typeof]()

### uint
[Документация Microsoft - uint]()

### ulong
[Документация Microsoft - ulong]()

### unchecked
[Документация Microsoft - unchecked]()

### unsafe
[Документация Microsoft - unsafe]()

### ushort
[Документация Microsoft - ushort]()

### using
[Документация Microsoft - using]()

### virtual
[Документация Microsoft - virtual]()

### void
[Документация Microsoft - void]()

### volatile
[Документация Microsoft - volatile]()

### while
[Документация Microsoft - while]()

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


