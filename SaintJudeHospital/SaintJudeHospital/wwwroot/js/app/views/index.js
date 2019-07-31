// ReSharper disable once InconsistentNaming
import Vue from 'vue'

// ReSharper disable once InconsistentNaming
import App from './App'

Vue.config.productionTip = false;

new Vue({
    el: '#main-app',
    template: '<App/>',
    components: {
        App
    }
});
