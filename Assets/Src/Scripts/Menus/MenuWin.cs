using UnityEngine.UI;

namespace YsoCorp {

    public  class MenuWin : AMenu {

        public Button bNext;
        public YsoCorp.Player initSpeed;

        void Start() {
            this.bNext.onClick.AddListener(() => {
                this.ycManager.adsManager.ShowInterstitial(() => {
                    this.game.state = Game.States.Home;
                    initSpeed.ResetSpeed();
                });
            });
        }

    }

}
