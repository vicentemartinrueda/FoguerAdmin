import Vue from 'vue';
import App from './App.vue';
import VueRouter from 'vue-router'
import './quasar'


Vue.use(VueRouter)
const router = new VueRouter({
    routes: [{
        path: '*',
      }]

  })
Vue.config.productionTip = true;

new Vue({
    router,
    render: h => h(App)
}).$mount('#app');
