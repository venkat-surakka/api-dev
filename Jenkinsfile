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
        bat 'dotnet run --project api-practice'
      }
    }

  }
}