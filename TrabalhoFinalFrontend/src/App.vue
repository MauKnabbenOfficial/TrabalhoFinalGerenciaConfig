<template>
  <div id="app">
    <header>
      <nav>
        <router-link to="/">HomeAlterada</router-link>
        <!-- <router-link to="/about">About</router-link> -->
      </nav>
    </header>
    <main>
      <!-- Onde o conteúdo da rota será renderizado -->
      <router-view />
    </main>
    <footer>
      <p>© 2024 Meu Projeto Vue</p>
    </footer>
  </div>
</template>

<script setup lang="ts"></script>

<style scoped></style>
