﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml.Controls;

namespace WizardMobile.Uwp.Gameplay
{
    public interface IWizardComponentProvider
    {
        void SetMessageBoxText(string message);
        void SetPlayerCreationInputVisibility(bool isVisible);
        void SetHumanPlayerBidInputVisibility(bool isVisible);
        void BeginAnimations();
        void QueueAnimationsCompletedHandler(Action action);        
        void OnPlayerCreationInputEntered(Action<string> action); // action receives (string playerInput)
        void OnPlayerBidInputEntered(Action<int> action); // action receives (string playerName, int bid)

        // card groups 
        StackCardGroup CenterCardGroup { get; }
        TaperedStackCardGroup LeftCenterCardGroup { get; }
        TaperedStackCardGroup RightCenterCardGroup { get; }
        AdjacentCardGroup DiscardCardGroup { get; }
        InteractiveAdjacentCardGroup Player1CardGroup { get; }
        StackCardGroup Player1StagingCardGroup { get; }
        AdjacentCardGroup Player2CardGroup { get; }
        StackCardGroup Player2StagingCardGroup { get; }
        AdjacentCardGroup Player3CardGroup { get; }
        StackCardGroup Player3StagingCardGroup { get; }
        AdjacentCardGroup Player4CardGroup { get; }
        StackCardGroup Player4StagingCardGroup { get; }

    }
}
