//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input Manager/PlayerControlls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControlls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControlls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControlls"",
    ""maps"": [
        {
            ""name"": ""Character"",
            ""id"": ""a96c92af-14fe-431c-a4a0-fb9bf8114967"",
            ""actions"": [
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""f0bdb138-55a8-455b-a743-3cf2cefbc413"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""34fe6de4-54ea-464c-81a8-3ffa4895fd36"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Aim"",
                    ""type"": ""Value"",
                    ""id"": ""ad0c3a6c-1e40-49c0-bd81-0b30c5e351d2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""04fa023f-ea19-4ccd-b4ef-339b818afa27"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""EquipSlot1"",
                    ""type"": ""Button"",
                    ""id"": ""e9d895c4-3881-49cf-845a-1d95f291fcbf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""EquipSlot2"",
                    ""type"": ""Button"",
                    ""id"": ""28e92c38-b1f7-4ce1-8206-1604f6f9a517"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""EquipSlot3"",
                    ""type"": ""Button"",
                    ""id"": ""747c7791-afb8-433b-832f-9f2b1b4a7770"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""EquipSlot4"",
                    ""type"": ""Button"",
                    ""id"": ""b777d566-571a-4d8e-9f0c-ceb616c0d499"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""EquipSlot5"",
                    ""type"": ""Button"",
                    ""id"": ""9c7752da-e928-4b94-8b88-6e53c64bc29f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DropCurrentWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""6aa730bd-03d6-4124-a914-69dcacb9c729"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""ddd6a39b-5c68-4046-98b1-924f95e4c5e9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ToggleWeaponMode"",
                    ""type"": ""Button"",
                    ""id"": ""1e83f0c0-e524-42bc-971e-754bd263d308"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""cf74d6e5-e1ea-41fd-a07f-2d6bbb3531a4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ed847252-d664-4b0f-a8b4-dd2721285219"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WSAD"",
                    ""id"": ""6ecf1427-bddf-4d40-9ea0-e314b8ca91e3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""99f19332-eee3-47c0-8ede-3705b6323850"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9c80a135-da40-4a4c-8e4a-bd3a2c1f49d3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""33b81caa-51ba-4dee-8a73-fd656d7e7dad"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5b684b91-b285-4265-9f8f-c30cb9a5649f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a622fe71-8ba9-4409-ba1f-d050623064ac"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a652abcf-9495-4137-ac9a-5ec2f8187546"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f67e771-809f-44f7-b83e-2fa087490717"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EquipSlot1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""473311af-f27c-4a17-8ebc-9d8c9e6cb5d5"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EquipSlot2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d52b07ac-b49e-4c80-a1f8-d3a81d4b35c7"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropCurrentWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c1fe919d-9ea1-4873-9d1d-9df2a485415e"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9b65ebf7-75e8-4f3d-ace9-9acb21103e8d"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EquipSlot3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00c84192-f012-4818-90db-3b70b2f6aff6"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EquipSlot4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d614ea5-302f-42b5-b076-3253c5cda51c"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EquipSlot5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6bf5e8bf-ff5a-4b90-b958-abcffb3504c5"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleWeaponMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""062d1c42-f312-4a39-a0ef-fbbcd9ff87c6"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Character
        m_Character = asset.FindActionMap("Character", throwIfNotFound: true);
        m_Character_Fire = m_Character.FindAction("Fire", throwIfNotFound: true);
        m_Character_Movement = m_Character.FindAction("Movement", throwIfNotFound: true);
        m_Character_Aim = m_Character.FindAction("Aim", throwIfNotFound: true);
        m_Character_Run = m_Character.FindAction("Run", throwIfNotFound: true);
        m_Character_EquipSlot1 = m_Character.FindAction("EquipSlot1", throwIfNotFound: true);
        m_Character_EquipSlot2 = m_Character.FindAction("EquipSlot2", throwIfNotFound: true);
        m_Character_EquipSlot3 = m_Character.FindAction("EquipSlot3", throwIfNotFound: true);
        m_Character_EquipSlot4 = m_Character.FindAction("EquipSlot4", throwIfNotFound: true);
        m_Character_EquipSlot5 = m_Character.FindAction("EquipSlot5", throwIfNotFound: true);
        m_Character_DropCurrentWeapon = m_Character.FindAction("DropCurrentWeapon", throwIfNotFound: true);
        m_Character_Reload = m_Character.FindAction("Reload", throwIfNotFound: true);
        m_Character_ToggleWeaponMode = m_Character.FindAction("ToggleWeaponMode", throwIfNotFound: true);
        m_Character_Interaction = m_Character.FindAction("Interaction", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Character
    private readonly InputActionMap m_Character;
    private List<ICharacterActions> m_CharacterActionsCallbackInterfaces = new List<ICharacterActions>();
    private readonly InputAction m_Character_Fire;
    private readonly InputAction m_Character_Movement;
    private readonly InputAction m_Character_Aim;
    private readonly InputAction m_Character_Run;
    private readonly InputAction m_Character_EquipSlot1;
    private readonly InputAction m_Character_EquipSlot2;
    private readonly InputAction m_Character_EquipSlot3;
    private readonly InputAction m_Character_EquipSlot4;
    private readonly InputAction m_Character_EquipSlot5;
    private readonly InputAction m_Character_DropCurrentWeapon;
    private readonly InputAction m_Character_Reload;
    private readonly InputAction m_Character_ToggleWeaponMode;
    private readonly InputAction m_Character_Interaction;
    public struct CharacterActions
    {
        private @PlayerControlls m_Wrapper;
        public CharacterActions(@PlayerControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fire => m_Wrapper.m_Character_Fire;
        public InputAction @Movement => m_Wrapper.m_Character_Movement;
        public InputAction @Aim => m_Wrapper.m_Character_Aim;
        public InputAction @Run => m_Wrapper.m_Character_Run;
        public InputAction @EquipSlot1 => m_Wrapper.m_Character_EquipSlot1;
        public InputAction @EquipSlot2 => m_Wrapper.m_Character_EquipSlot2;
        public InputAction @EquipSlot3 => m_Wrapper.m_Character_EquipSlot3;
        public InputAction @EquipSlot4 => m_Wrapper.m_Character_EquipSlot4;
        public InputAction @EquipSlot5 => m_Wrapper.m_Character_EquipSlot5;
        public InputAction @DropCurrentWeapon => m_Wrapper.m_Character_DropCurrentWeapon;
        public InputAction @Reload => m_Wrapper.m_Character_Reload;
        public InputAction @ToggleWeaponMode => m_Wrapper.m_Character_ToggleWeaponMode;
        public InputAction @Interaction => m_Wrapper.m_Character_Interaction;
        public InputActionMap Get() { return m_Wrapper.m_Character; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterActions set) { return set.Get(); }
        public void AddCallbacks(ICharacterActions instance)
        {
            if (instance == null || m_Wrapper.m_CharacterActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CharacterActionsCallbackInterfaces.Add(instance);
            @Fire.started += instance.OnFire;
            @Fire.performed += instance.OnFire;
            @Fire.canceled += instance.OnFire;
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Aim.started += instance.OnAim;
            @Aim.performed += instance.OnAim;
            @Aim.canceled += instance.OnAim;
            @Run.started += instance.OnRun;
            @Run.performed += instance.OnRun;
            @Run.canceled += instance.OnRun;
            @EquipSlot1.started += instance.OnEquipSlot1;
            @EquipSlot1.performed += instance.OnEquipSlot1;
            @EquipSlot1.canceled += instance.OnEquipSlot1;
            @EquipSlot2.started += instance.OnEquipSlot2;
            @EquipSlot2.performed += instance.OnEquipSlot2;
            @EquipSlot2.canceled += instance.OnEquipSlot2;
            @EquipSlot3.started += instance.OnEquipSlot3;
            @EquipSlot3.performed += instance.OnEquipSlot3;
            @EquipSlot3.canceled += instance.OnEquipSlot3;
            @EquipSlot4.started += instance.OnEquipSlot4;
            @EquipSlot4.performed += instance.OnEquipSlot4;
            @EquipSlot4.canceled += instance.OnEquipSlot4;
            @EquipSlot5.started += instance.OnEquipSlot5;
            @EquipSlot5.performed += instance.OnEquipSlot5;
            @EquipSlot5.canceled += instance.OnEquipSlot5;
            @DropCurrentWeapon.started += instance.OnDropCurrentWeapon;
            @DropCurrentWeapon.performed += instance.OnDropCurrentWeapon;
            @DropCurrentWeapon.canceled += instance.OnDropCurrentWeapon;
            @Reload.started += instance.OnReload;
            @Reload.performed += instance.OnReload;
            @Reload.canceled += instance.OnReload;
            @ToggleWeaponMode.started += instance.OnToggleWeaponMode;
            @ToggleWeaponMode.performed += instance.OnToggleWeaponMode;
            @ToggleWeaponMode.canceled += instance.OnToggleWeaponMode;
            @Interaction.started += instance.OnInteraction;
            @Interaction.performed += instance.OnInteraction;
            @Interaction.canceled += instance.OnInteraction;
        }

        private void UnregisterCallbacks(ICharacterActions instance)
        {
            @Fire.started -= instance.OnFire;
            @Fire.performed -= instance.OnFire;
            @Fire.canceled -= instance.OnFire;
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Aim.started -= instance.OnAim;
            @Aim.performed -= instance.OnAim;
            @Aim.canceled -= instance.OnAim;
            @Run.started -= instance.OnRun;
            @Run.performed -= instance.OnRun;
            @Run.canceled -= instance.OnRun;
            @EquipSlot1.started -= instance.OnEquipSlot1;
            @EquipSlot1.performed -= instance.OnEquipSlot1;
            @EquipSlot1.canceled -= instance.OnEquipSlot1;
            @EquipSlot2.started -= instance.OnEquipSlot2;
            @EquipSlot2.performed -= instance.OnEquipSlot2;
            @EquipSlot2.canceled -= instance.OnEquipSlot2;
            @EquipSlot3.started -= instance.OnEquipSlot3;
            @EquipSlot3.performed -= instance.OnEquipSlot3;
            @EquipSlot3.canceled -= instance.OnEquipSlot3;
            @EquipSlot4.started -= instance.OnEquipSlot4;
            @EquipSlot4.performed -= instance.OnEquipSlot4;
            @EquipSlot4.canceled -= instance.OnEquipSlot4;
            @EquipSlot5.started -= instance.OnEquipSlot5;
            @EquipSlot5.performed -= instance.OnEquipSlot5;
            @EquipSlot5.canceled -= instance.OnEquipSlot5;
            @DropCurrentWeapon.started -= instance.OnDropCurrentWeapon;
            @DropCurrentWeapon.performed -= instance.OnDropCurrentWeapon;
            @DropCurrentWeapon.canceled -= instance.OnDropCurrentWeapon;
            @Reload.started -= instance.OnReload;
            @Reload.performed -= instance.OnReload;
            @Reload.canceled -= instance.OnReload;
            @ToggleWeaponMode.started -= instance.OnToggleWeaponMode;
            @ToggleWeaponMode.performed -= instance.OnToggleWeaponMode;
            @ToggleWeaponMode.canceled -= instance.OnToggleWeaponMode;
            @Interaction.started -= instance.OnInteraction;
            @Interaction.performed -= instance.OnInteraction;
            @Interaction.canceled -= instance.OnInteraction;
        }

        public void RemoveCallbacks(ICharacterActions instance)
        {
            if (m_Wrapper.m_CharacterActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICharacterActions instance)
        {
            foreach (var item in m_Wrapper.m_CharacterActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CharacterActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CharacterActions @Character => new CharacterActions(this);
    public interface ICharacterActions
    {
        void OnFire(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnAim(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnEquipSlot1(InputAction.CallbackContext context);
        void OnEquipSlot2(InputAction.CallbackContext context);
        void OnEquipSlot3(InputAction.CallbackContext context);
        void OnEquipSlot4(InputAction.CallbackContext context);
        void OnEquipSlot5(InputAction.CallbackContext context);
        void OnDropCurrentWeapon(InputAction.CallbackContext context);
        void OnReload(InputAction.CallbackContext context);
        void OnToggleWeaponMode(InputAction.CallbackContext context);
        void OnInteraction(InputAction.CallbackContext context);
    }
}
