namespace Lazy

/// Интерфейс, представляющий ленивое вычисление
type ILazy<'a> =

    /// При первом вызове вычисляет объект типа Т и возвращает результат,
    /// повторные вызовы возвращают тот же объект
    abstract member Get: unit -> 'a