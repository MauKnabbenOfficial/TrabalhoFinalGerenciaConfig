<template>
  <div v-if="data">
    {{ data }}
  </div>
</template>

<script setup lang="ts">
import { onMounted, ref } from "vue";
import ApiService from "../services/ApiService";

const data = ref("");

async function fetchData() {
  try {
    const response = await ApiService.get("/home/info");
    data.value = response.data;
  } catch (error) {
    data.value = "Erro ao buscar dados";
    console.error("Erro ao buscar dados:", error);
  }
}

onMounted(async () => {
  await fetchData();
});
</script>
