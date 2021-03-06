//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly LoadNextLevelTriggerComponent loadNextLevelTriggerComponent = new LoadNextLevelTriggerComponent();

    public bool isLoadNextLevelTrigger {
        get { return HasComponent(GameComponentsLookup.LoadNextLevelTrigger); }
        set {
            if (value != isLoadNextLevelTrigger) {
                var index = GameComponentsLookup.LoadNextLevelTrigger;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : loadNextLevelTriggerComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherLoadNextLevelTrigger;

    public static Entitas.IMatcher<GameEntity> LoadNextLevelTrigger {
        get {
            if (_matcherLoadNextLevelTrigger == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.LoadNextLevelTrigger);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherLoadNextLevelTrigger = matcher;
            }

            return _matcherLoadNextLevelTrigger;
        }
    }
}
