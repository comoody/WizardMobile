﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media.Animation;
using WizardMobile.Uwp.Common;

namespace WizardMobile.Uwp.Gameplay
{
    public interface ICanvasFacade
    {
        void AddCard
        (
            UniqueDisplayCard card,
            NormalizedPosition position,
            double orientationDegrees,
            int zIndex
        );
        void UpdateCard
        (
            UniqueDisplayCard cardToUpdate,
            NormalizedPosition canvasPositon = null,
            double? orientationDegrees = null,
            int? zIndex = null,
            bool? dimmed = null
        );
        void RemoveCard(UniqueDisplayCard card);
        Task<NormalizedSize> GetNormalizedCardImageSize();
        void QueueAnimationRequest(AnimationRequest animation);
        void QueueAnimationRequests(IEnumerable<AnimationRequest> animations);
        event Action<UniqueDisplayCard> CardClicked; // fires when any card is clicked, passing the card to the handler
        event Action<UniqueDisplayCard> CardPointerEntered;
        event Action<UniqueDisplayCard> CardPointerExited;
    }
}
