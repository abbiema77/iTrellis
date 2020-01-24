import Vue from 'vue';
import App from './App.vue';
import axios from 'axios';
import router from './router';
import store from './store';
import { BootstrapVue } from 'bootstrap-vue';
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'

Vue.config.productionTip = true;
Vue.prototype.$api = axios;
Vue.use(BootstrapVue)

new Vue({
    router,
    store,
    render: h => h(App)
}).$mount('#app');
 