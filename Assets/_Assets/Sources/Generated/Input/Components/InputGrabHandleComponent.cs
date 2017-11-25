//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputEntity {

    public GrabHandleComponent grabHandle { get { return (GrabHandleComponent)GetComponent(InputComponentsLookup.GrabHandle); } }
    public bool hasGrabHandle { get { return HasComponent(InputComponentsLookup.GrabHandle); } }

    public void AddGrabHandle(GameEntity newTarget) {
        var index = InputComponentsLookup.GrabHandle;
        var component = CreateComponent<GrabHandleComponent>(index);
        component.Target = newTarget;
        AddComponent(index, component);
    }

    public void ReplaceGrabHandle(GameEntity newTarget) {
        var index = InputComponentsLookup.GrabHandle;
        var component = CreateComponent<GrabHandleComponent>(index);
        component.Target = newTarget;
        ReplaceComponent(index, component);
    }

    public void RemoveGrabHandle() {
        RemoveComponent(InputComponentsLookup.GrabHandle);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class InputMatcher {

    static Entitas.IMatcher<InputEntity> _matcherGrabHandle;

    public static Entitas.IMatcher<InputEntity> GrabHandle {
        get {
            if (_matcherGrabHandle == null) {
                var matcher = (Entitas.Matcher<InputEntity>)Entitas.Matcher<InputEntity>.AllOf(InputComponentsLookup.GrabHandle);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherGrabHandle = matcher;
            }

            return _matcherGrabHandle;
        }
    }
}