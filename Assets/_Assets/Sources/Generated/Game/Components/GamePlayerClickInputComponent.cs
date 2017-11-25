//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public PlayerClickInputComponent playerClickInput { get { return (PlayerClickInputComponent)GetComponent(GameComponentsLookup.PlayerClickInput); } }
    public bool hasPlayerClickInput { get { return HasComponent(GameComponentsLookup.PlayerClickInput); } }

    public void AddPlayerClickInput(GameEntity newTarget) {
        var index = GameComponentsLookup.PlayerClickInput;
        var component = CreateComponent<PlayerClickInputComponent>(index);
        component.Target = newTarget;
        AddComponent(index, component);
    }

    public void ReplacePlayerClickInput(GameEntity newTarget) {
        var index = GameComponentsLookup.PlayerClickInput;
        var component = CreateComponent<PlayerClickInputComponent>(index);
        component.Target = newTarget;
        ReplaceComponent(index, component);
    }

    public void RemovePlayerClickInput() {
        RemoveComponent(GameComponentsLookup.PlayerClickInput);
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

    static Entitas.IMatcher<GameEntity> _matcherPlayerClickInput;

    public static Entitas.IMatcher<GameEntity> PlayerClickInput {
        get {
            if (_matcherPlayerClickInput == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PlayerClickInput);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPlayerClickInput = matcher;
            }

            return _matcherPlayerClickInput;
        }
    }
}
