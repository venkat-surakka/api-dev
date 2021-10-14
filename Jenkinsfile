pipeline {
  agent any
  stages {
    stage('build') {
      steps {
        bat 'dotnet build'
      }
    }

    stage('deploy') {
      steps {
        bat 'dotnet publish'
      }
    }

    stage('restart iis') {
      steps {
        bat 'iisreset'
      }
    }

  }
}