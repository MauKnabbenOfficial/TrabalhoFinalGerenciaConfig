import { createApp } from "vue";
import "./style.css";
import App from "./App.vue";
import router from "./router/router";

// Criação da instância do app Vue
const app = createApp(App);

// Uso do Vue Router
app.use(router);

// Monta o app na div com id "app"
app.mount("#app");
