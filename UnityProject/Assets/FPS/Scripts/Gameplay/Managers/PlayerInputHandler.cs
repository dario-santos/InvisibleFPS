using Unity.FPS.Game;
using UnityEngine;


namespace Unity.FPS.Gameplay
{
    public class PlayerInputHandler : MonoBehaviour
    {
        [Tooltip("Sensitivity multiplier for moving the camera around")]
        public float LookSensitivity = 1f;

        [Tooltip("Additional sensitivity multiplier for WebGL")]
        public float WebglLookSensitivityMultiplier = 0.25f;

        [Tooltip("Limit to consider an input when using a trigger on a controller")]
        public float TriggerAxisThreshold = 0.4f;

        [Tooltip("Used to flip the vertical input axis")]
        public bool InvertYAxis = false;

        [Tooltip("Used to flip the horizontal input axis")]
        public bool InvertXAxis = false;

        GameFlowManager m_GameFlowManager;
        PlayerCharacterController m_PlayerCharacterController;
        bool m_FireInputWasHeld;


        private PlayerControllerInput controls;

        private bool isAimPressed;
        private bool isFirePressed;
        private bool isJumpPressed;
        private bool isCrouchPressed;
        private bool isSprintPressed;


        private Vector3 playerMovementAmmount;
        private Vector2 cameraMovementAmmount;

        private void Awake()
        {
            controls = new PlayerControllerInput();

            // Fire
            controls.PlayerController.Fire.started  += _ => isFirePressed = true;
            controls.PlayerController.Fire.canceled += _ => isFirePressed = false;

            // Fire
            controls.PlayerController.Aim.started += _ => isAimPressed = true;
            controls.PlayerController.Aim.canceled += _ => isAimPressed = false;

            // Jump
            controls.PlayerController.Jump.started  += _ => isJumpPressed = true;
            controls.PlayerController.Jump.canceled += _ => isJumpPressed = false;

            // Crouch
            controls.PlayerController.Crouch.started  += _ => isCrouchPressed = true;
            controls.PlayerController.Crouch.canceled += _ => isCrouchPressed = false;

            // PlayerMovement
            controls.PlayerController.PlayerMovement.performed += ctx => MovePlayer(ctx.ReadValue<Vector2>());
            controls.PlayerController.PlayerMovement.canceled  += _ => MovePlayer(Vector2.zero);

            // CameraMovement
            controls.PlayerController.CameraMovement.performed += ctx => MoveCamera(ctx.ReadValue<Vector2>());
            controls.PlayerController.CameraMovement.canceled  += _ => MoveCamera(Vector2.zero);
        }

        void Start()
        {
            m_PlayerCharacterController = GetComponent<PlayerCharacterController>();
            DebugUtility.HandleErrorIfNullGetComponent<PlayerCharacterController, PlayerInputHandler>(m_PlayerCharacterController, this, gameObject);
            m_GameFlowManager = FindObjectOfType<GameFlowManager>();
            DebugUtility.HandleErrorIfNullFindObject<GameFlowManager, PlayerInputHandler>(m_GameFlowManager, this);

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        void MovePlayer(Vector2 playerMovementAmmount) { this.playerMovementAmmount = new Vector3(playerMovementAmmount.x, 0, playerMovementAmmount.y); }

        void MoveCamera(Vector2 cameraMovementAmmount) {

            float i = cameraMovementAmmount.y;

            // handle inverting vertical input
            if (InvertYAxis)
                i *= -1f;

            // apply sensitivity multiplier
            // since mouse input is already deltaTime-dependant, only scale input with frame time if it's coming from sticks
            i *= LookSensitivity * Time.deltaTime;

            this.cameraMovementAmmount = new Vector2(cameraMovementAmmount.x, cameraMovementAmmount.y); 
        }


        void LateUpdate()
        {
            m_FireInputWasHeld = GetFireInputHeld();
        }

        public bool CanProcessInput()
        {
            // Todo update to new input system
            return true; //Cursor.lockState == CursorLockMode.Locked && !m_GameFlowManager.GameIsEnding;
        }

        public Vector3 GetMoveInput()
        {
            if (CanProcessInput())
            {
                Vector3 move = playerMovementAmmount;

                // constrain move input to a maximum magnitude of 1, otherwise diagonal movement might exceed the max move speed defined
                move = Vector3.ClampMagnitude(move, 1);

                return move;
            }

            return Vector3.zero;
        }

        public float GetLookInputsHorizontal()
            => cameraMovementAmmount.x * 0.01f;

        public float GetLookInputsVertical()
            => cameraMovementAmmount.y * -0.01f;

        public bool GetJumpInputDown()
        {
            if (CanProcessInput())
            {
                return isJumpPressed;
            }

            return false;
        }

        public bool GetJumpInputHeld()
        {
            if (CanProcessInput())
                return isJumpPressed;

            return false;
        }

        public bool GetFireInputDown()
        {
            return GetFireInputHeld() && !m_FireInputWasHeld;
        }

        public bool GetFireInputReleased()
        {
            return !GetFireInputHeld() && m_FireInputWasHeld;
        }

        public bool GetFireInputHeld()
        {
            if (CanProcessInput())
                return isFirePressed;

            return false;
        }

        public bool GetAimInputHeld()
        {
            if (CanProcessInput())
                return isAimPressed;

            return false;
        }

        public bool GetSprintInputHeld()
        {
            if (CanProcessInput())
            {
                // Todo:
                //return Input.GetButton(GameConstants.k_ButtonNameSprint);
            }

            return false;
        }

        public bool GetCrouchInputDown()
        {
            if (CanProcessInput())
            {
                return isCrouchPressed;
            }

            return false;
        }

        public bool GetCrouchInputReleased()
        {
            if (CanProcessInput())
            {
                //Todo:
                return !isCrouchPressed;
            }

            return false;
        }

        public bool GetReloadButtonDown()
        {
            if (CanProcessInput())
            {
                //return Input.GetButtonDown(GameConstants.k_ButtonReload);
            }

            return false;
        }

        public int GetSwitchWeaponInput()
        {
            if (CanProcessInput())
            {

                /*bool isGamepad = Input.GetAxis(GameConstants.k_ButtonNameGamepadSwitchWeapon) != 0f;
                string axisName = isGamepad
                    ? GameConstants.k_ButtonNameGamepadSwitchWeapon
                    : GameConstants.k_ButtonNameSwitchWeapon;

                if (Input.GetAxis(axisName) > 0f)
                    return -1;
                else if (Input.GetAxis(axisName) < 0f)
                    return 1;
                else if (Input.GetAxis(GameConstants.k_ButtonNameNextWeapon) > 0f)
                    return -1;
                else if (Input.GetAxis(GameConstants.k_ButtonNameNextWeapon) < 0f)
                    return 1;
                */
            }

            return 0;
        }

        public int GetSelectWeaponInput()
        {
            if (CanProcessInput())
            {
                /*
                if (Input.GetKeyDown(KeyCode.Alpha1))
                    return 1;
                else if (Input.GetKeyDown(KeyCode.Alpha2))
                    return 2;
                else if (Input.GetKeyDown(KeyCode.Alpha3))
                    return 3;
                else if (Input.GetKeyDown(KeyCode.Alpha4))
                    return 4;
                else if (Input.GetKeyDown(KeyCode.Alpha5))
                    return 5;
                else if (Input.GetKeyDown(KeyCode.Alpha6))
                    return 6;
                else if (Input.GetKeyDown(KeyCode.Alpha7))
                    return 7;
                else if (Input.GetKeyDown(KeyCode.Alpha8))
                    return 8;
                else if (Input.GetKeyDown(KeyCode.Alpha9))
                    return 9;
                else
                    return 0;
                */
            }

            return 0;
        }

        private void OnEnable()
        {
            controls.Enable();
        }

        private void OnDisable()
        {
            controls.Disable();
        }
    }
}