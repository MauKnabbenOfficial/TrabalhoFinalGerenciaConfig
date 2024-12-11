import { createRouter, createWebHistory } from "vue-router";
import HomeView from "../views/HomeView.vue";

const routes = [
  { path: "/", name: "Home", component: HomeView },
  //   { path: '/about', name: 'About', component: AboutView },
];

const router = createRouter({
  history: createWebHistory(), // Usa o modo de histórico HTML5
  routes,
});

export default router;
