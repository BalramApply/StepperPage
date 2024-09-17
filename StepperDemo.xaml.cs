namespace StepperPage;

public partial class StepperPage : ContentPage
{
    public StepperPage()
    {
        InitializeComponent();
    }

    private void UpdateAttendees(object sender, ValueChangedEventArgs args)
    {
        lblAttendees.Text = stepperAttendees.Value.ToString();
    }

    private void UpdateInterest(object sender, ValueChangedEventArgs args)
    {
        lblInterest.Text = stepperInterest.Value.ToString("P1");
    }

    private void UpdateInterest2(object sender, ValueChangedEventArgs args)
    {
        lblInterst2.Text = (stepperInterestInt.Value + stepperInterestDouble.Value).ToString("N1") + "%";
    }
}