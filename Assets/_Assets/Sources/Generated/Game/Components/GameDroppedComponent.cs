//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public DroppedComponent dropped { get { return (DroppedComponent)GetComponent(GameComponentsLookup.Dropped); } }
    public bool hasDropped { get { return HasComponent(GameComponentsLookup.Dropped); } }

    public void AddDropped(float newForce) {
        var index = GameComponentsLookup.Dropped;
        var component = CreateComponent<DroppedComponent>(index);
        component.Force = newForce;
        AddComponent(index, component);
    }

    public void ReplaceDropped(float newForce) {
        var index = GameComponentsLookup.Dropped;
        var component = CreateComponent<DroppedComponent>(index);
        component.Force = newForce;
        ReplaceComponent(index, component);
    }

    public void RemoveDropped() {
        RemoveComponent(GameComponentsLookup.Dropped);
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
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherDropped;

    public static Entitas.IMatcher<GameEntity> Dropped {
        get {
            if (_matcherDropped == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Dropped);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDropped = matcher;
            }

            return _matcherDropped;
        }
    }
}