// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue';
import App from './App';
// import router from './router';
import VueRouter from 'vue-router';
import VueResource from 'vue-resource';
import goods from './components/goods/goods.vue';
import seller from './components/seller/seller.vue';
import ratings from './components/ratings/ratings.vue';
import './common/stylus/index.styl';

Vue.use(VueRouter);
Vue.use(VueResource);

// Vue.config.productionTip = false

/* eslint-disable no-new */
// new Vue({
//   el: '#app',
//   router,
//   template: '<App/>',
//   components: { App }
// });
const routes=[
  {path:'/goods',component:goods},
  {path:'/seller',component:seller},
  {path:'/ratings',component:ratings}
];
const router=new VueRouter({
  routes,
  linkActiveClass:'active'
});
export default router;
//router.push('goods');// 相当于页面初始化，显示goods的内容

// 挂载
new Vue({
  el: '#app',
  template: '<App/>',
  router: router,
  components: { App }
});