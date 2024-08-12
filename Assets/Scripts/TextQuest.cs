using TMPro;
using UnityEngine;

public class TextQuest : MonoBehaviour
{
    #region Variables

    [SerializeField] private TMP_Text _descriptionLabel;
    [SerializeField] private TMP_Text _answerLabel;

    [SerializeField] private Step _startStep;
    [SerializeField] private Step _currentStep;

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        SetCurrentStepAndUpdateUi(_startStep);
    }

    private void Update()
    {
        for (int i = 1; i <= 9; i++)
        {
            if (Input.GetKeyDown(i.ToString()))
            {
                TryGoToNextStep(i);
            }
        }
    }

    #endregion

    #region Private methods

    private void SetCurrentStepAndUpdateUi(Step step)
    {
        _currentStep = step;
        
        if(_currentStep.NextSteps.Length == 0)
        {
            //todo: Debug.Log("Game over!");
        }

        UpdateUI();
    }

    private void TryGoToNextStep(int number)
    {
        int nextStepsCount = _currentStep.NextSteps.Length;
        if (number > nextStepsCount)
        {
            return;
        }
        
        int nextStepIndex = number - 1;
        Step nextStep = _currentStep.NextSteps[nextStepIndex];
        SetCurrentStepAndUpdateUi(nextStep);
    }

    private void UpdateUI()
    {
        _descriptionLabel.text = _currentStep.Description;
        _answerLabel.text = _currentStep.Answers;
    }

    #endregion
}