//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly InteractibleComponent interactibleComponent = new InteractibleComponent();

    public bool isInteractible {
        get { return HasComponent(GameComponentsLookup.Interactible); }
        set {
            if (value != isInteractible) {
                var index = GameComponentsLookup.Interactible;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : interactibleComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GameEntity> _matcherInteractible;

    public static Entitas.IMatcher<GameEntity> Interactible {
        get {
            if (_matcherInteractible == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Interactible);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherInteractible = matcher;
            }

            return _matcherInteractible;
        }
    }
}
