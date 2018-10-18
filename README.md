# UnityDataBindingExample

## Unity-Weld

- https://github.com/Real-Serious-Games/Unity-Weld
- Easy to use with INotifyPropertyChanged (+)

## ugui-mvvm

- https://github.com/jbruening/ugui-mvvm
- Errors on integration, but works (-)

## DataBind

- https://github.com/tinrab/DataBind
- Special way for binding, custom syntax for binding (-)

# Variant1

- When linked with INotifyPropertyChanged from ViewModel we can't modify models directly, only from ViewModel, and we need reference to it (-)

# Variant2

- Use thin ViewModel with backing to Model props/events
- No limitations to what exactly we modify, model modification events fired in all cases (++)
- More boilerplace code, but we can expose in VM only part of props, if required (-)

# Both variants

- With Unity-Weld we need valid model before Weld components Awake, can be solved with Script Execution Order (-)
