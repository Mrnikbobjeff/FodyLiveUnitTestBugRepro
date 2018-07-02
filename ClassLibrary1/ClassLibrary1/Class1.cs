using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;

namespace ClassLibrary1
{
    public class Class1 : ReactiveObject
    {
        [Reactive]
        public bool BoolToChange { get; set; }

        public bool Inverse { get; set; }
        public Class1()
        {
            this.WhenAnyValue(x => x.BoolToChange).Subscribe(val => Inverse = !val);
        }
    }
}
