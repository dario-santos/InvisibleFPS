// GENERATED AUTOMATICALLY FROM 'Assets/FPS/Scripts/Gameplay/Managers/PlayerController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControllerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControllerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerController"",
    ""maps"": [
        {
            ""name"": ""PlayerController"",
            ""id"": ""e7a7a32f-ca68-4f7e-b42a-4ebf25929048"",
            ""actions"": [
                {
                    ""name"": ""Aim"",
                    ""type"": ""Button"",
                    ""id"": ""ce3c992c-7b62-406c-9d7b-3e129889cbd3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraMovement"",
                    ""type"": ""Value"",
                    ""id"": ""c1d6264d-ea41-4de1-be7f-6f652deac0ce"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeGunNext"",
                    ""type"": ""Button"",
                    ""id"": ""0ce1389e-5970-4bc7-947d-82a7e156e73f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeGunPrevious"",
                    ""type"": ""Button"",
                    ""id"": ""618fab0d-4cc2-4498-9023-20aa30c9a773"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""413de8cd-9421-4118-b1b4-ff68f3615d32"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""1285395a-d3d3-4ba6-bc6d-671183760a1b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""87b9fc97-d789-4b14-8c92-861f2c322c88"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlayerMovement"",
                    ""type"": ""Value"",
                    ""id"": ""8f8079d4-809f-44b7-baf1-78e6fad17640"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraMovementMouseX"",
                    ""type"": ""Value"",
                    ""id"": ""e9dd5f84-a39f-4773-b9f4-1e73a80f0f97"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CameraMovementMouseY"",
                    ""type"": ""Value"",
                    ""id"": ""36aa9693-6b34-4292-8bbe-593e92d7b8ff"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeGun1"",
                    ""type"": ""Button"",
                    ""id"": ""cc9134c6-a4dd-42bb-8a59-fe06d71fb042"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeGun2"",
                    ""type"": ""Button"",
                    ""id"": ""0d566e6d-2e39-4372-b4d1-3f068e81fba6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeGun3"",
                    ""type"": ""Button"",
                    ""id"": ""d874436c-7e6a-432f-9e9a-badc7060f354"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2a3a9a66-3413-42b2-8b62-d7667ef60a34"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a0bcf3c2-d82b-41c8-ac44-04fc9a43266b"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a261af0-e04b-4030-a06a-b0d7092d0e3c"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""b3f46bc6-d649-4141-a42c-e254f9c6e2df"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""50d72d38-234d-499e-a005-9bf1efe4c39e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a8f46086-f0cb-4a6a-add1-ac62baf02d99"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f49df7ea-d4da-465e-8523-b7d21f0b79b0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""58be90d3-a6c9-4038-b115-3e178d2d790f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""PlayerMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""01dfa7b8-76f0-47ed-ba77-b8ab0a183c81"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0dc23327-4366-4667-b0cf-cad886d73aeb"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eebc1c7b-53da-4f70-a3f1-f4952fb5b3b1"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""165e90ae-25ec-4513-aca0-0265af7d6931"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Aim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e95c57d-ff9f-4d3e-b6d6-537f20e90c5e"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""471099b0-6a3c-4ee3-a49e-f6100de789a4"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""137f17da-44fb-417f-9fda-caa283263288"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""CameraMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84c89a54-1da1-42e7-acef-1c0e91ccf0e2"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""ChangeGunNext"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9826404f-dde8-4569-8146-dd7f942a5c7a"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""ChangeGunPrevious"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec39b269-79a0-437f-aea5-53ac89f614c6"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""CameraMovementMouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7764972-fd0c-4071-8d92-f490f8705cdb"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""CameraMovementMouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0ae9d4b-1d0a-4ea2-889b-061c9ff5b34a"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeGun1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2b3de8fb-5310-4ada-b75b-683fe775dd44"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeGun1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e8f7c379-2fa1-4db0-a2b2-070725c65ecc"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeGun2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""653fa208-210b-4e6c-b465-2f769fcfd1ea"",
                    ""path"": ""<Keyboard>/numpad2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeGun2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af09b11e-c6b2-4b07-8234-2ba4ab3434a0"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeGun3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""009b6d2e-b4f4-4a08-80cb-8351481c3e75"",
                    ""path"": ""<Keyboard>/numpad3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeGun3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardMouse"",
            ""bindingGroup"": ""KeyboardMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<VirtualMouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Controller"",
            ""bindingGroup"": ""Controller"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerController
        m_PlayerController = asset.FindActionMap("PlayerController", throwIfNotFound: true);
        m_PlayerController_Aim = m_PlayerController.FindAction("Aim", throwIfNotFound: true);
        m_PlayerController_CameraMovement = m_PlayerController.FindAction("CameraMovement", throwIfNotFound: true);
        m_PlayerController_ChangeGunNext = m_PlayerController.FindAction("ChangeGunNext", throwIfNotFound: true);
        m_PlayerController_ChangeGunPrevious = m_PlayerController.FindAction("ChangeGunPrevious", throwIfNotFound: true);
        m_PlayerController_Crouch = m_PlayerController.FindAction("Crouch", throwIfNotFound: true);
        m_PlayerController_Fire = m_PlayerController.FindAction("Fire", throwIfNotFound: true);
        m_PlayerController_Jump = m_PlayerController.FindAction("Jump", throwIfNotFound: true);
        m_PlayerController_PlayerMovement = m_PlayerController.FindAction("PlayerMovement", throwIfNotFound: true);
        m_PlayerController_CameraMovementMouseX = m_PlayerController.FindAction("CameraMovementMouseX", throwIfNotFound: true);
        m_PlayerController_CameraMovementMouseY = m_PlayerController.FindAction("CameraMovementMouseY", throwIfNotFound: true);
        m_PlayerController_ChangeGun1 = m_PlayerController.FindAction("ChangeGun1", throwIfNotFound: true);
        m_PlayerController_ChangeGun2 = m_PlayerController.FindAction("ChangeGun2", throwIfNotFound: true);
        m_PlayerController_ChangeGun3 = m_PlayerController.FindAction("ChangeGun3", throwIfNotFound: true);
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

    // PlayerController
    private readonly InputActionMap m_PlayerController;
    private IPlayerControllerActions m_PlayerControllerActionsCallbackInterface;
    private readonly InputAction m_PlayerController_Aim;
    private readonly InputAction m_PlayerController_CameraMovement;
    private readonly InputAction m_PlayerController_ChangeGunNext;
    private readonly InputAction m_PlayerController_ChangeGunPrevious;
    private readonly InputAction m_PlayerController_Crouch;
    private readonly InputAction m_PlayerController_Fire;
    private readonly InputAction m_PlayerController_Jump;
    private readonly InputAction m_PlayerController_PlayerMovement;
    private readonly InputAction m_PlayerController_CameraMovementMouseX;
    private readonly InputAction m_PlayerController_CameraMovementMouseY;
    private readonly InputAction m_PlayerController_ChangeGun1;
    private readonly InputAction m_PlayerController_ChangeGun2;
    private readonly InputAction m_PlayerController_ChangeGun3;
    public struct PlayerControllerActions
    {
        private @PlayerControllerInput m_Wrapper;
        public PlayerControllerActions(@PlayerControllerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Aim => m_Wrapper.m_PlayerController_Aim;
        public InputAction @CameraMovement => m_Wrapper.m_PlayerController_CameraMovement;
        public InputAction @ChangeGunNext => m_Wrapper.m_PlayerController_ChangeGunNext;
        public InputAction @ChangeGunPrevious => m_Wrapper.m_PlayerController_ChangeGunPrevious;
        public InputAction @Crouch => m_Wrapper.m_PlayerController_Crouch;
        public InputAction @Fire => m_Wrapper.m_PlayerController_Fire;
        public InputAction @Jump => m_Wrapper.m_PlayerController_Jump;
        public InputAction @PlayerMovement => m_Wrapper.m_PlayerController_PlayerMovement;
        public InputAction @CameraMovementMouseX => m_Wrapper.m_PlayerController_CameraMovementMouseX;
        public InputAction @CameraMovementMouseY => m_Wrapper.m_PlayerController_CameraMovementMouseY;
        public InputAction @ChangeGun1 => m_Wrapper.m_PlayerController_ChangeGun1;
        public InputAction @ChangeGun2 => m_Wrapper.m_PlayerController_ChangeGun2;
        public InputAction @ChangeGun3 => m_Wrapper.m_PlayerController_ChangeGun3;
        public InputActionMap Get() { return m_Wrapper.m_PlayerController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControllerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControllerActions instance)
        {
            if (m_Wrapper.m_PlayerControllerActionsCallbackInterface != null)
            {
                @Aim.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnAim;
                @Aim.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnAim;
                @Aim.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnAim;
                @CameraMovement.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCameraMovement;
                @CameraMovement.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCameraMovement;
                @CameraMovement.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCameraMovement;
                @ChangeGunNext.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnChangeGunNext;
                @ChangeGunNext.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnChangeGunNext;
                @ChangeGunNext.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnChangeGunNext;
                @ChangeGunPrevious.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnChangeGunPrevious;
                @ChangeGunPrevious.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnChangeGunPrevious;
                @ChangeGunPrevious.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnChangeGunPrevious;
                @Crouch.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCrouch;
                @Fire.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnFire;
                @Jump.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnJump;
                @PlayerMovement.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnPlayerMovement;
                @PlayerMovement.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnPlayerMovement;
                @PlayerMovement.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnPlayerMovement;
                @CameraMovementMouseX.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCameraMovementMouseX;
                @CameraMovementMouseX.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCameraMovementMouseX;
                @CameraMovementMouseX.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCameraMovementMouseX;
                @CameraMovementMouseY.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCameraMovementMouseY;
                @CameraMovementMouseY.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCameraMovementMouseY;
                @CameraMovementMouseY.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnCameraMovementMouseY;
                @ChangeGun1.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnChangeGun1;
                @ChangeGun1.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnChangeGun1;
                @ChangeGun1.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnChangeGun1;
                @ChangeGun2.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnChangeGun2;
                @ChangeGun2.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnChangeGun2;
                @ChangeGun2.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnChangeGun2;
                @ChangeGun3.started -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnChangeGun3;
                @ChangeGun3.performed -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnChangeGun3;
                @ChangeGun3.canceled -= m_Wrapper.m_PlayerControllerActionsCallbackInterface.OnChangeGun3;
            }
            m_Wrapper.m_PlayerControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Aim.started += instance.OnAim;
                @Aim.performed += instance.OnAim;
                @Aim.canceled += instance.OnAim;
                @CameraMovement.started += instance.OnCameraMovement;
                @CameraMovement.performed += instance.OnCameraMovement;
                @CameraMovement.canceled += instance.OnCameraMovement;
                @ChangeGunNext.started += instance.OnChangeGunNext;
                @ChangeGunNext.performed += instance.OnChangeGunNext;
                @ChangeGunNext.canceled += instance.OnChangeGunNext;
                @ChangeGunPrevious.started += instance.OnChangeGunPrevious;
                @ChangeGunPrevious.performed += instance.OnChangeGunPrevious;
                @ChangeGunPrevious.canceled += instance.OnChangeGunPrevious;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @PlayerMovement.started += instance.OnPlayerMovement;
                @PlayerMovement.performed += instance.OnPlayerMovement;
                @PlayerMovement.canceled += instance.OnPlayerMovement;
                @CameraMovementMouseX.started += instance.OnCameraMovementMouseX;
                @CameraMovementMouseX.performed += instance.OnCameraMovementMouseX;
                @CameraMovementMouseX.canceled += instance.OnCameraMovementMouseX;
                @CameraMovementMouseY.started += instance.OnCameraMovementMouseY;
                @CameraMovementMouseY.performed += instance.OnCameraMovementMouseY;
                @CameraMovementMouseY.canceled += instance.OnCameraMovementMouseY;
                @ChangeGun1.started += instance.OnChangeGun1;
                @ChangeGun1.performed += instance.OnChangeGun1;
                @ChangeGun1.canceled += instance.OnChangeGun1;
                @ChangeGun2.started += instance.OnChangeGun2;
                @ChangeGun2.performed += instance.OnChangeGun2;
                @ChangeGun2.canceled += instance.OnChangeGun2;
                @ChangeGun3.started += instance.OnChangeGun3;
                @ChangeGun3.performed += instance.OnChangeGun3;
                @ChangeGun3.canceled += instance.OnChangeGun3;
            }
        }
    }
    public PlayerControllerActions @PlayerController => new PlayerControllerActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardMouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.FindControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    public interface IPlayerControllerActions
    {
        void OnAim(InputAction.CallbackContext context);
        void OnCameraMovement(InputAction.CallbackContext context);
        void OnChangeGunNext(InputAction.CallbackContext context);
        void OnChangeGunPrevious(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnPlayerMovement(InputAction.CallbackContext context);
        void OnCameraMovementMouseX(InputAction.CallbackContext context);
        void OnCameraMovementMouseY(InputAction.CallbackContext context);
        void OnChangeGun1(InputAction.CallbackContext context);
        void OnChangeGun2(InputAction.CallbackContext context);
        void OnChangeGun3(InputAction.CallbackContext context);
    }
}
